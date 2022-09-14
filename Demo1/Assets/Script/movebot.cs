using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebot : MonoBehaviour
{
    
    void Update()
    {
        transform.Translate(Vector3.down * 5 * Time.deltaTime);
    }
}
