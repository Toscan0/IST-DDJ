using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class putObject : MonoBehaviour {
    public string name;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnInteractionWithItem(InventoryManager i)
    {
        if (i.InventoryHas(name))
        {
            foreach (Transform child in this.gameObject.transform) 
            {
                child.gameObject.SetActive(true);
            }
            this.gameObject.layer = 0;

            GameObject puzzle = GameObject.Find("FinalPuzzle").gameObject;
            puzzle.GetComponent<LastPuzzle>().Counter = 1;
            
               
        }

    }

}
