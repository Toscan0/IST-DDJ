using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class breakBottle: MonoBehaviour {
    public GameObject _bottle;
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
            //GameObject brokenGlass = GameObject.Find("/House/Kitchen/brokenBottle");
            _bottle.SetActive(true);
        }
    }
}
