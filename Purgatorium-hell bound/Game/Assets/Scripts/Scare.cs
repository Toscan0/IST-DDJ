using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scare : MonoBehaviour
{
    //[SerializeField] private Image customImage;
	public Transform image;
    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;

    private bool alreadyPlayed = false;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter()
    {
        if (alreadyPlayed == false)
        {
            GameObject door = GameObject.Find("Dinning Room Door/Door_01").gameObject;
            if(door.GetComponent<door>().Locked == false)
            {
                image.gameObject.SetActive(true);
                audio.PlayOneShot(SoundToPlay, Volume);
                

                alreadyPlayed = true;
            }
            
        }
		
		
    }
	
	    public void OnTriggerExit()
    {
		image.gameObject.SetActive(false);
		
		
    }

}
