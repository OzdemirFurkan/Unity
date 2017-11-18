using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletManagement : MonoBehaviour {

	public int power;
	private Animator m_zombiAnim;


	void OnCollisionEnter(Collision col)
	{
		if (col.collider.gameObject.name.Contains("zombi")) {
			m_zombiAnim = col.gameObject.GetComponent<Animator>();
			m_zombiAnim.SetBool ("death", true);

			col.gameObject.GetComponent<zombieManagement>().StartCoroutine("kill");

			Destroy (gameObject);

		}
	}
		
}
