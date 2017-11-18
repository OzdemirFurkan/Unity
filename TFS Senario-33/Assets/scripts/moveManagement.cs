using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class moveManagement : MonoBehaviour {
    public int speed;
    private Rigidbody m_rgBody;
    private Animator m_anim;
    private Transform myTransform;
    public Transform m_bulletTransform;
    public GameObject bullet;
    public Image healthBar;
    private float health = 1f;


    void Start () {
        m_rgBody = GetComponent<Rigidbody>();
        m_anim = GetComponent<Animator>();
        myTransform = GetComponent<Transform>();
	}

	void Update () {
        float dikeyEksenHareket = Input.GetAxis("Vertical") * speed; //* Time.deltaTime;
        float yatayEksenHareket = Input.GetAxis("Horizontal") * (speed * 10) ;
        dikeyEksenHareket *= Time.deltaTime;
        yatayEksenHareket *= Time.deltaTime;

        myTransform.Translate(0, 0, dikeyEksenHareket);
        myTransform.Rotate(0, yatayEksenHareket, 0);

        if (Input.GetButtonDown("Fire1"))
        {
            m_anim.SetBool("isFire", true);
            GameObject createdBullet = (GameObject)Instantiate(bullet, m_bulletTransform.position, gameObject.transform.rotation);
            Rigidbody rbody = createdBullet.GetComponent<Rigidbody>();
            rbody.AddRelativeForce(0, 0, 300, ForceMode.Impulse);
        }
        if (!Input.GetButtonDown("Fire1"))
        {
            m_anim.SetBool("isFire", false);
        }

        if (dikeyEksenHareket != 0 || yatayEksenHareket != 0)
        {
            Run();
        }
        if (dikeyEksenHareket == 0 && yatayEksenHareket == 0)
        {
            Stop();
        }

        healthBar.fillAmount = health;

	    if (Math.Abs(health) < 0)
	    {
	        SceneManager.LoadScene(1);
	    }


    }
    public void OnCollisionEnter(Collision col)
    {
        //Debug.Log("if side health: " + health);
        if (col.collider.gameObject.name.Contains("zombi"))
        {
            health -= 0.1f;
            Debug.Log("health: " + health);
        }
    }
    void Run()
    {
        m_anim.SetBool("isRun", true);
        m_anim.SetBool("isIdle", false);
    }
    void Stop()
    {
        m_anim.SetBool("isRun", false);
        m_anim.SetBool("isIdle", true);
    }
 

}
