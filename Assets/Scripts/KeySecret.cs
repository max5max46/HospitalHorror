using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySecret : MonoBehaviour
{
    public int Keys = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey("e") && Keys == 3)
        {

        }
    }
}
