using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

namespace VRGame
{
    public class CharacterSelectPresenter : MonoBehaviour
    {
        [SerializeField] private Button _aliciaButton;
        [SerializeField] private Button _vroidButton;

        void Start()
        {
            var aliciaStream = _aliciaButton.OnClickAsObservable().Select(_ => "AliciaSolid");
            var vroidStream = _vroidButton.OnClickAsObservable().Select(_ => "VRoid_test");
            
            var characterChangeComponents = GetComponent<CharacterSelectComponents>();

            // View → Model
            // キャラクターのボタンを押したらReactivePropertyの更新をする
            aliciaStream.Subscribe(name => characterChangeComponents.charaName.Value = name);
            vroidStream.Subscribe(name => characterChangeComponents.charaName.Value = name);

            // Model → View
            // 表示するモデルを変更する
            characterChangeComponents.charaName.SkipLatestValueOnSubscribe().Subscribe(name => 
            {
                var beforeCharaObject = FindModelObject(characterChangeComponents.beforeCharaName.Value);
                beforeCharaObject.SetActive(false);

                var charaObject = FindModelObject(name);
                charaObject.SetActive(true);
                characterChangeComponents.beforeCharaName.Value = characterChangeComponents.charaName.Value;

                // シーン間で選択されたキャラクターの情報を保持するための変数
                CharacterSelectComponents.SelectedCharacter = characterChangeComponents.charaName.Value;

            });
        }

        private GameObject FindModelObject(string name)
        {
            return GameObject.Find("Model").transform.Find(name).gameObject;
        }
    }
}