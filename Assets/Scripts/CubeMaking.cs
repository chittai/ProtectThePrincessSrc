using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMaking : MonoBehaviour {

    public GameObject cube;
    public GameObject muzzle;
    private float cubeLife;

	// Use this for initialization
	void Start () {
        
        StartCoroutine("MakeCube");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator MakeCube()
    {   
        for (int i = 0; i < 1000; i++)
        {
            yield return new WaitForSeconds(Random.Range(cubeLife, 3.0f));
            var random_x = Random.Range(-2.0f, 2.0f);
            var random_y = Random.Range(-1.23f, 0.3f);
            var z = 3.5f;

            cubeLife = 2.0f;
            GetComponent<PlaySoundEffect>().Sound();
            GameObject cubeINstance = Instantiate(cube, new Vector3(muzzle.transform.position.x, muzzle.transform.position.y, muzzle.transform.position.z), muzzle.transform.rotation);
            cubeINstance.transform.LookAt(new Vector3(random_x, random_y, z));
            Destroy(cubeINstance, cubeLife);

        }
    }

}
