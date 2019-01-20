using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scndfloorstart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider other)
    {
        GameObject player = GameObject.Find("Player");
        player.GetComponent<NotificationScript>().OnNotify("Power is gonne. Where is the electric box");
    }
}
