using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    //The sound that will play when an object enters this triger
    public AudioClip triggerSound;
    //The audio source will play that sound
    public AudioSource source;

    private void OnTriggerEnter(Collider other)
    {
        //Tell the source to play sound triggerSound once
        source.PlayOneShot(triggerSound);
    }
}
