﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMusicTrigger : MonoBehaviour {

	public AudioClip newTrack;
	private AudioManager theAM;


	// Use this for initialization
	void Start () {
		theAM = FindObjectOfType<AudioManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
		void OnTriggerEnter()
		{

				if(newTrack != null)
					theAM.ChangeBGM(newTrack);

		}
}
