using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour {
     bool open = false;
    [SerializeField] bool locked = false;
    [SerializeField] public string unlockWith = "";
    public AudioClip _openSound;
    public AudioClip _closeSound;
    public AudioClip _lockedSound;
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
            if(unlockWith.Equals("Charm2"))
            {
                player.GetComponent<NotificationScript>().OnNotify("This door is protected by a curse, should find and apply a charm just to be safe");
            }else if (unlockWith.Equals("kitchencode"))
            {
                player.GetComponent<NotificationScript>().OnNotify("I forgot the code. This markings on the wall must be the numbers order, but where are the numbers?");
            }else if (unlockWith.Equals("cadeira"))
            {
                player.GetComponent<NotificationScript>().OnNotify("Something locked the door...");
            }
            else
            {
                player.GetComponent<NotificationScript>().OnNotify("This door appears to be locked");
            }
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
                Debug.Log("Player used " + unlockWith);
                GameObject player = GameObject.Find("Player");
                player.GetComponent<NotificationScript>().OnNotify("Player used " + unlockWith);
                Locked = false;
            }
            else
            {
                Debug.Log("Player doesn't have " + unlockWith);
               
            }
        }
    }
}
