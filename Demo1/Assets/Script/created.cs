using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class created : MonoBehaviour
{   
    public GameObject doituong;
    public GameObject vitri;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateObj());
    }

    IEnumerator CreateObj(){
        yield return new WaitForSeconds(2);
        Vector3 temp_y = vitri.transform.position;

        temp_y.y = Random.Range(-4f,3f);
        Instantiate(doituong, temp_y, Quaternion.identity);
        StartCoroutine(CreateObj());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
