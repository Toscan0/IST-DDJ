using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {

    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter()
    {
        if (!alreadyPlayed)
        {
            audio.PlayOneShot(SoundToPlay, Volume);
            alreadyPlayed = true;
            if(SoundToPlay.name.Equals("Monster 1"))
            {
                GameObject player = GameObject.Find("Player");
                player.GetComponent<NotificationScript>().OnNotify("He's out there!!! If He finds me, He will kill me");
            }
        }
    }
}

