using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pieces : MonoBehaviour {
    public int _myPos;
    public int _finalPos; //const, doesn't change

    private GameObject _player;
    
	// Use this for initialization
	void Start () {
	    _player	=  GameObject.Find("Player").gameObject;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnInteractionLP(int i)
    {
        //get pos
        Vector3 pos = this.gameObject.transform.position;
        string name = this.gameObject.name;

        GameObject puzzle = GameObject.Find("puzzle solved").gameObject;
        
        if(i == 1)
        {
            puzzle.GetComponent<grid>().Pos1 = pos;
            puzzle.GetComponent<grid>().Name1 = name;
            puzzle.GetComponent<grid>().PosG1 = _myPos;
        }
        if(i == 2)
        {
            puzzle.GetComponent<grid>().Pos2 = pos;
            puzzle.GetComponent<grid>().Name2 = name;
            puzzle.GetComponent<grid>().PosG2 = _myPos;
        }
        i++;
        if(i == 3)
        {
            i = 1;
        }

        puzzle.GetComponent<grid>().Changed = true;

        GameObject player = GameObject.Find("Player/Main Camera").gameObject;
        player.GetComponent<InputManager>().Counter = i;
    }

    public int MyPos
    {
        get
        {
            return _myPos;
        }

        set
        {
            _myPos = value;
        }
    }

    public int FinalPos
    {
        get
        {
            return _finalPos;
        }

        set
        {
            _finalPos = value;
        }
    }
}
