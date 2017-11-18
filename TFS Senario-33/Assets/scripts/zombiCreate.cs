using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiCreate : MonoBehaviour {
    public GameObject m_zombi;
    public GameObject character;
    private bool isCreate = true;
    public int counter = 10;

	// Use this for initialization
	void Start () {
        StartCoroutine(createZombi());
	}
	public IEnumerator createZombi()
    {
        while (isCreate == true)
        {
            GameObject zombi = (GameObject) Instantiate(m_zombi, new Vector3(character.transform.position.x + Random.insideUnitSphere.x * 10, 
                character.transform.position.y, 
                character.transform.position.x + Random.insideUnitSphere.z * 10), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            counter--;
            if (counter <= 0)
            {
                isCreate = false;
                counter = 10;
                break;
            }

        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
