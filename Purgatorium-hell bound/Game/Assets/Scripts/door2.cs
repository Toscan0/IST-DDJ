using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door2 : MonoBehaviour {
     bool open = false;
    [SerializeField] bool locked = false;
    [SerializeField] string unlockWith = "";
    public AudioClip _openSound;
    public AudioClip _closeSound;
    public AudioClip _lockedSound;
	
	public AudioClip newTrack;
	private AudioManager theAM;
	
    AudioSource audio;
    Animator m_Animator;

    public bool Open
    {
        get
        {
            return open;
        }

        set
        {
            open = value;
        }
    }

    public bool Locked
    {
        get
        {
            return locked;
        }

        set
        {
            locked = value;
        }
    }

    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
        m_Animator = GetComponent<Animator>();
		theAM = FindObjectOfType<AudioManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnInteraction(Vector3 point)
    {
        if (Locked)
        {
            Debug.Log("door Locked");
            GameObject player = GameObject.Find("Player");
            player.GetComponent<NotificationScript>().OnNotify("This door appears to be locked");
            //should say door locked to the user
            audio.PlayOneShot(_lockedSound, 2);
        }
        else if (Open && !Locked)
        {
            //transform.parent.transform.Rotate(Vector3.up, 90);
            Open = !Open;
            audio.PlayOneShot(_closeSound, 2);
            m_Animator.Play("cl");
        }
        else {
           // transform.parent.transform.Rotate(Vector3.up, -90);
            Open = !Open;
            m_Animator.Play("op");
            audio.PlayOneShot(_openSound, 2);
        }
    }
    public void OnUnlock(InventoryManager i)
    {
        if (Locked)
        {
            if (i.InventoryHas(unlockWith))
            {

				theAM.ChangeBGM(newTrack);
                Debug.Log("Player used " + unlockWith);
                GameObject player = GameObject.Find("Player");
                player.GetComponent<NotificationScript>().OnNotify("Unlocked with " + unlockWith);
                Locked = false;
				

            }
            else
            {
                Debug.Log("Player doesn't have " + unlockWith);
                GameObject player = GameObject.Find("Player");
                player.GetComponent<NotificationScript>().OnNotify("I must first find the key");

            }
        }
    }
}
