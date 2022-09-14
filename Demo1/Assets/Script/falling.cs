using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling : MonoBehaviour
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
      //  Vector3 temp_y = vitri1.transform.position;
        Vector3 temp_x = vitri1.transform.position;
     //   temp_y.y = Random.Range(5.55f,5.15f);
        temp_x.x = Random.Range(-9f,9f);
        
        Instantiate(doituong, temp_x, Quaternion.identity);
        StartCoroutine(CreateObj());
    }

    void Update()
    {
        
    }
}
