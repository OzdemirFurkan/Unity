using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class vrLook : MonoBehaviour {
    private bool isCreate = true;
    public void VrLookAtMe(bool m)
    {
       

            Debug.Log("Bakıyorsun");
        StartCoroutine(lookAndFall());
    
}

    public IEnumerator lookAndFall()
    {
            yield return new WaitForSeconds(5f);
            gameObject.GetComponent<Rigidbody>().useGravity = true;


            }
    }
}