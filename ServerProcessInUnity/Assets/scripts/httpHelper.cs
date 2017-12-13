using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class httpHelper : MonoBehaviour {
    public string url = "http://www.google.com";
    public InputField userName;
    public InputField userPass;

    public void connectionClick()
    {
        StartCoroutine(Baglan());
    }
    public IEnumerator Baglan()
    {
        WWW con = new WWW(url);
        WWWForm form1 = new WWWForm();
        form1.AddField("userName", userName.text);
        form1.AddField("userPass", userPass.text);
        yield return con;
    }
}
