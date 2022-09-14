using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class created2 : MonoBehaviour
{
    public GameObject doituong,doituong2;
    public GameObject vitri1;
    public GameObject vitri2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateObj());
    }

    IEnumerator CreateObj(){
        yield return new WaitForSeconds(1);
        Vector3 temp_y = vitri1.transform.position;
        Vector3 temp_y1 = vitri2.transform.position;

        temp_y.y = Random.Range(-4f,-1f);
        temp_y1.y = Random.Range(1f,4f);
        Instantiate(doituong, temp_y, Quaternion.identity);
        Instantiate(doituong2, temp_y1, Quaternion.identity);
        StartCoroutine(CreateObj());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
