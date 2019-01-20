using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenLockScript : MonoBehaviour {
    public door door;
    public InventoryManager playerInv;
    public AudioClip _arrastarMovelSom;
    public float Volume;
    AudioSource audio;
	
	public AudioClip newTrack;
	private AudioManager theAM;
	
    bool triggered = false;
    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
		theAM = FindObjectOfType<AudioManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter()
    {
       if(triggered == false)
        {
            if(door.Open)
            {
                door.OnInteraction(Vector3.one);
            }
            door.Locked=true;
            door.unlockWith = "cadeira";
            audio.PlayOneShot(_arrastarMovelSom, Volume);
            triggered = true;
			theAM.ChangeBGM(newTrack);

            //cadeira que tranca a porta
            Transform cadeira = GameObject.Find("cadeira disabled").transform;

            foreach (Transform child in cadeira)
            {

                if (child.gameObject.name == "chair_1")
                {
                    child.gameObject.SetActive(true);

                }

            }
       }
    }
}
