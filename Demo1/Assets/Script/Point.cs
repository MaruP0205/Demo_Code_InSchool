using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    // Start is called before the first frame update
    public Text txtDiem;
    int diemcong = 0;
    public void UpdateScore(){
        diemcong ++;
        txtDiem.text = "Score: "+ diemcong;
    }
    public void UpdateBoss(){
        diemcong = diemcong + 100;
        txtDiem.text = "Score: "+diemcong;
    }
}
