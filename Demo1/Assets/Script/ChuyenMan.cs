using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChuyenMan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ok(){
        SceneManager.LoadScene("Begin");
    }
    public void replay(){
        SceneManager.LoadScene("MainGame");
    }
}
