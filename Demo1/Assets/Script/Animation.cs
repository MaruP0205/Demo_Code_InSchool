using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator ani;
    
  /*  public bool trangthai;
    void OnTriggerEnter2D(Collider2D colli){
        if(colli.gameObject.tag == "nen"){
        
            trangthai = true;
        }
    }*/
    void Start()
    {
        
        ani = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        //right
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(Time.deltaTime * 5, 0 , 0);
            transform.localScale = new Vector3(0.4550455F,0.5037435F,0);
            ani.SetBool("chay2",true);
            ani.SetBool("nhay2",false);
        }
        //left
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(-Time.deltaTime * 5, 0 , 0);
            transform.localScale = new Vector3(-0.4550455F,0.5037435F,0);
            ani.SetBool("chay2",true);
            ani.SetBool("nhay2",false);
        } 
        //Jump
        if(Input.GetKey(KeyCode.W)){
         //   if(trangthai == true){
          //  trangthai = false;
            transform.Translate( 0,Time.deltaTime * 8 , 0);
            transform.localScale = new Vector3(0.4550455F,0.5037435F,0);
            ani.SetBool("nhay2",true);
            ani.SetBool("chay2",false);
           // }
        }
        //JumpRight
         if(Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W)){
            transform.localScale = new Vector3(0.4550455F,0.5037435F,0);
            transform.Translate(Time.deltaTime * 3,Time.deltaTime * 3 , 0);
             ani.SetBool("nhay2",true);
             ani.SetBool("chay2",true);
           
         }

         //JumpLeft
         if(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W)){
            transform.localScale = new Vector3(-0.4550455F,0.5037435F,0);
            transform.Translate(-Time.deltaTime * 3,-Time.deltaTime * 3 , 0);
            ani.SetBool("nhay2",true);
            ani.SetBool("chay2",true);
           
         }
        
    }
    
  
}
