using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaoMoi : MonoBehaviour
{   
    
    public InputField ID;
    public InputField USER;
    public InputField PASS;
    public InputField LEVEL;
    public InputField POINT;

    string php_dangky = "http://localhost/php/dangky.php";

    public void themmoi(){
        StartCoroutine(connect());
    }

    IEnumerator connect(){
        WWWForm wf = new WWWForm();

        wf.AddField("id_chuyen",ID.text);
        wf.AddField("user_chuyen",USER.text);
        wf.AddField("pass_chuyen",PASS.text);
        wf.AddField("level_chuyen",LEVEL.text);
        wf.AddField("point_chuyen",POINT.text);

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
