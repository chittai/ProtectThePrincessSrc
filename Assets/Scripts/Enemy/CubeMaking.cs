﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRGame
{
    public class CubeMaking : MonoBehaviour
    {

        public GameObject cube;
        public GameObject muzzle;

        private float _cubeLife;
        private PlaySoundEffect _playSoundEffect;

        void Start()
        {
            _playSoundEffect = GetComponent<PlaySoundEffect>();
            StartCoroutine("MakeCube");
        }

        /// <summary>
        /// 敵からくる攻撃のCubeを作成する。狙う座標は範囲指定でランダムで決定
        /// </summary>
        /// <returns></returns>
        IEnumerator MakeCube()
        {
            for (int i = 0; i < 1000; i++)
            {
                yield return new WaitForSeconds(Random.Range(_cubeLife, 3.0f));
                var random_x = Random.Range(-2.0f, 2.0f);
                var random_y = Random.Range(-1.23f, 0.3f);
                var z = 3.5f;

                _cubeLife = 2.0f;
                _playSoundEffect.Sound();
                GameObject cubeINstance = Instantiate(cube, new Vector3(muzzle.transform.position.x, muzzle.transform.position.y, muzzle.transform.position.z), muzzle.transform.rotation);
                cubeINstance.transform.LookAt(new Vector3(random_x, random_y, z));
                Destroy(cubeINstance, _cubeLife);
            }
        }
    }
}