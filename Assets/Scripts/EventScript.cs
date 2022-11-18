using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class EventScript : MonoBehaviour
{

    public PlayableDirector timeline;

    public bool OneTimeTrigger = false; // true = this trigger will self destruct after one use.

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            timeline.Play();
            Destroy(this.gameObject);

        }
    }
}
