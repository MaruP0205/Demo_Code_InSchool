using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class listuser : MonoBehaviour
{

    public GameObject rownew;
    string URL = "http://localhost/PHP/showuser.php";
    // Start is called before the first frame update
    void Start()
    {
        getdata();
    }
    public void getdata(){
        StartCoroutine(connect());
    }
    IEnumerator connect(){
        WWWForm wf = new WWWForm();
        WWW w = new WWW(URL,wf);
        yield return w;
        string data = w.text;

        string[] a = new string[]{};
        a = data.Split(',');
        for (int i=0;i< (a.Length)-1; i++){
            string dong = a[i];
            string[] b = new string[]{};
            b = dong.Split('-');
            GameObject g = (GameObject)Instantiate(rownew);
                g.transform.SetParent(this.transform);
                g.transform.Find("id").GetComponent<Text>().text = b[0];
                g.transform.Find("user").GetComponent<Text>().text = b[1];
                g.transform.Find("pass").GetComponent<Text>().text = b[2];
                g.transform.Find("lev").GetComponent<Text>().text = b[3];
                g.transform.Find("poi").GetComponent<Text>().text = b[4];
        }
    }
}
