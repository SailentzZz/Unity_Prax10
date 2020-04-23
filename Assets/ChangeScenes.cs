using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Application.LoadLevel("Prax_10_1");
        }
           if(Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel("Prax_10_2");
        }
    }
}
