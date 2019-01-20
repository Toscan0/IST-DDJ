using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalChest : MonoBehaviour {
    private bool _open = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnInteraction(Vector3 point)
    {
        Transform puzzle = GameObject.Find("FinalPuzzle").transform;

        foreach (Transform child in puzzle)
        {
            if (child.gameObject.name == "monstroSound")
            {
                child.gameObject.SetActive(true);

            }
            if (child.gameObject.name == "puzzle solved")
            {
                child.gameObject.SetActive(true);

            }
            if (child.gameObject.name == "lore")
            {
                child.gameObject.SetActive(true);

            }
        }
        Open = true;
        this.gameObject.layer = 0;
    }

    public bool Open
    {
        get
        {
            return _open;
        }

        set
        {
            _open = value;
        }
    }
}
