using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMusicTrigger2 : MonoBehaviour {

	public AudioClip newTrack;
	private AudioManager theAM;
    private bool alreadyPlayed = false;


	// Use this for initialization
	void Start () {
		theAM = FindObjectOfType<AudioManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
		void OnTriggerEnter()
		{
			if (alreadyPlayed == false)
			{
				alreadyPlayed = true;
				if(newTrack != null)
					theAM.ChangeBGM(newTrack);
			}
		}
}
