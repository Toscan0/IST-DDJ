using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	public AudioSource BGM;
	bool last = false;
	
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void ChangeBGM(AudioClip music)
		{
			if(BGM.clip.name == music.name)
				return;
			
			if(last == true)
				return;
			
			BGM.Stop();
			BGM.clip = music;
			BGM.Play();
			
			if(music.name == "Bloodborne Soundtrack OST - The Witch of Hemwick")
				last = true;
		}
}
