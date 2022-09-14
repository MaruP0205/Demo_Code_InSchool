using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class VaCham : MonoBehaviour
{   
    void Start()
    {
       
    }
     void OnTriggerEnter2D(Collider2D colli ){
        if(colli.gameObject.tag == "tag_left"){
          Destroy(GameObject.Find("Player2"));
          SceneManager.LoadScene("Died");
           
        }
          else if(colli.gameObject.tag == "tag_top"){
            Destroy(GameObject.Find("Player2"));
           SceneManager.LoadScene("Died");
           
        }
        else if(colli.gameObject.tag == "tag_right"){
            Destroy(GameObject.Find("Player2"));
           SceneManager.LoadScene("Died");
        }

        
    } 
    
}
