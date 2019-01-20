using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerLastPuzzle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter()
    {
        Transform puzzle = GameObject.Find("FinalPuzzle").transform;
        puzzle.GetComponent<LastPuzzle>().Inside = true;
    }
}
