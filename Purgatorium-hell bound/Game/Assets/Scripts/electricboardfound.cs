using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electricboardfound : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        GameObject player = GameObject.Find("Player");
        player.GetComponent<NotificationScript>().OnNotify("Here is the electric box. But the connections are broken. Must fix it");
    }
}
