using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class created3 : MonoBehaviour
{
    public GameObject doituong;
    public GameObject vitri1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateObj());
    }

    IEnumerator CreateObj(){
        yield return new WaitForSeconds(1);
       Vector3 temp_y = vitri1.transform.position;
     //   temp_y.y = Random.Range(5.55f,5.15f);
        temp_y.y = Random.Range(-4f,4f);
        
        Instantiate(doituong, temp_y, Quaternion.identity);
        StartCoroutine(CreateObj());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
