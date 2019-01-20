using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Firstlevelscenemanager : MonoBehaviour {
    public GameObject _root;
    public GameObject _player;
    public GameObject _finaldoor;
    public int count;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        count = SceneManager.sceneCount;

        if (SceneManager.sceneCount>1)
        {
            ToPuzzle();
        }
        else
        {
            FromPuzzle();
        }
	}

    public void ToPuzzle()
    {
        _player.SetActive(false);
        _root.SetActive(false);
        Cursor.visible = true;
    }

    public void FromPuzzle()
    {
        _player.SetActive(true);
        _root.SetActive(true);
       
    }

    public void changeFinalDoor()
    {
        _finaldoor.GetComponent<door>().Locked = false;
    }
}
