using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpDecreasing : MonoBehaviour {
    
    public static int hp { get; set; }

    public GameObject particle;

	// Use this for initialization
	void Start () {
        hp = 2;
	}
	
    public void BreakHeart()
    {
        var heart = this.transform.GetChild(hp).gameObject;
        Instantiate(particle, heart.transform.position, particle.transform.rotation);
        heart.SetActive(false);
        hp--;
        // Destroy(particleInstance, 2);
    }

}
