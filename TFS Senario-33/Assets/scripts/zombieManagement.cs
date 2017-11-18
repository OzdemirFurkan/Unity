using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieManagement : MonoBehaviour {

	public float speed;

	private GameObject m_characterSoldier;
	private Animator m_zombiAnim;


	// Use this for initialization
	void Start () {
		m_characterSoldier = GameObject.Find ("ToonSoldier_demo").gameObject;

		m_zombiAnim = gameObject.GetComponent<Animator>();

	}

	void LateUpdate() {
		if (m_zombiAnim.GetBool("death") != true) {
			m_zombiAnim.SetBool ("run", true);
			m_zombiAnim.SetBool ("idle", false);
			transform.LookAt (m_characterSoldier.transform);
			transform.position = Vector3.MoveTowards (transform.position, m_characterSoldier.transform.position, speed * Time.deltaTime);
		}
	}
	public IEnumerator kill(){
		yield return new WaitForSeconds (1);
		Destroy (gameObject);
	}
	// Update is called once per frame

}
