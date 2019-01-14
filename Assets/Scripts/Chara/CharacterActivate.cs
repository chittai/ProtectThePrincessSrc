using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRGame
{
    public class CharacterActivate : MonoBehaviour
    {
        void Awake()
        {
            this.transform.Find(CharacterSelectComponents.SelectedCharacter).gameObject.SetActive(true);
        }
    }
}