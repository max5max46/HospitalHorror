using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript1 : MonoBehaviour

{
    public GameObject DoorObject;
    public GameObject Key;
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey("e"))
        {
            var Door = DoorObject.GetComponent<KeySecret>();
            Door.Keys++;
        }
    }
}
