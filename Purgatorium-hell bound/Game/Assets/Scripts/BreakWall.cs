using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakWall : MonoBehaviour
{
    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;

    private bool disabled = false;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (alreadyPlayed && disabled == false)
        {
            //disable parede
            GameObject parede = GameObject.Find("BreakbleParede/Breakble").gameObject;
            parede.SetActive(false);

            Collider m_Collider = GetComponent<Collider>();
            m_Collider.enabled = !m_Collider.enabled;
            Destroy(m_Collider);

            disabled = true;

        }
    }

    public void OnInteractionWithItem(InventoryManager i)
    {
        // player have pedaço 1
        if (i.InventoryHas("marreta"))
        {
            //sound
            audio.PlayOneShot(SoundToPlay, Volume);
            alreadyPlayed = true;
        }else
        {
            GameObject player = GameObject.Find("Player");
            player.GetComponent<NotificationScript>().OnNotify("Must find something to break the wall with"); 
        }

    }
}