using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphireSoundManage : MonoBehaviour {

	private AudioSource aSource;
    // Use this for initialization

	void Start () {
        aSource = gameObject.GetComponent<AudioSource>();
	}

  
    private void OnCollisionEnter(Collision collision)
    {
        aSource.Play();
    }
}
