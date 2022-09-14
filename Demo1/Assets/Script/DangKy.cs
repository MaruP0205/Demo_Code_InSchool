using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DangKy : MonoBehaviour
{
    public InputField USER;
    public InputField PASS;

    string php_dangky = "http://localhost/php/dangky2.php";

    public void themmoi(){
        StartCoroutine(connect());
    }

    IEnumerator connect(){
        WWWForm wf = new WWWForm();

        
        wf.AddField("user_chuyen",USER.text);
        wf.AddField("pass_chuyen",PASS.text);

        WWW w = new WWW(php_dangky,wf);

        yield return w;

        string tam = w.text;
        string tam1 = tam.TrimStart();
        string tam2 = tam1.TrimEnd();

        if(tam2 == "thanh cong"){
            print("Chúc Mừng Bạn");
        }
        else{
            print("Bạn làm sai rồi, kiểm tra lại đê");
        }
    }
}
