using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace VRGame
{
    public class CharacterSelectComponents : MonoBehaviour
    {
        public ReactiveProperty<string> charaName = new ReactiveProperty<string>("AliciaSolid");
        public ReactiveProperty<string> beforeCharaName = new ReactiveProperty<string>("AliciaSolid");

        public static string SelectedCharacter { get; set; } = "AliciaSolid";

    }
}