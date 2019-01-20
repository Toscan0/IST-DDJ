using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class LastPuzzle : MonoBehaviour {
    public GameObject _monstro;
    public GameObject[] _triggers;
    public GameObject _videoGameOver;

    private bool _solved = false;
    private bool _solved2 = false;
    private int _counter = 0;
    private float timeLeft = 437.5f; //7 min
    private bool _inside = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject chestOpen = GameObject.Find("FinalChest").gameObject;
        if(chestOpen.GetComponent<FinalChest>().Open == true)
        {
            timeLeft -= Time.deltaTime;
            Debug.Log(timeLeft + " ....." + Time.deltaTime);
            if (timeLeft <= 0)
            {
               
                _monstro.SetActive(true);
                foreach(GameObject trigger in _triggers)
                {
                    trigger.SetActive(true);
                }
                if (timeLeft <= -2 && _inside == true)
                {
                    Debug.Log("!!!!!!!!!!!!!!!!! GAME OVER!!! !!!!!!!!!!!!");
                    _videoGameOver.SetActive(true);
                    _videoGameOver.GetComponent<VideoPlayer>().loopPointReached += LoadScene;
                    //SceneManager.LoadScene(sceneName: "2nd Floor Scene");
                }
            }
            if (_solved == false)
            {
                Transform puzzle = GameObject.Find("puzzle solved").transform;

                foreach (Transform child in puzzle) //pieces
                {
                    if (child.GetComponent<pieces>().MyPos == child.GetComponent<pieces>().FinalPos)
                    {
                        _solved = true;
                    }
                    else
                    {
                        _solved = false;
                        break;
                    }


                }
            }
        }
        if(_solved == true)
        {
            Transform puzzle = GameObject.Find("puzzle solved").transform;

            foreach (Transform child in puzzle) //pieces
            {
                child.gameObject.layer = 0;
            }

            foreach (Transform child in this.gameObject.transform)
            {
               if(child.gameObject.name == "Bonecos")
               {
                    child.gameObject.SetActive(true);
               }
            }            
        }
        if(_counter >= 3)
        {
            Debug.Log("------------------ GAME END!!! ---------------------");
            Transform puzzle = GameObject.Find("video").transform;
            foreach (Transform child in puzzle)
            {
                if(child.gameObject.name == "Video Player"){
                    child.gameObject.SetActive(true);
                }
            }
        }
        
    }

    void LoadScene(VideoPlayer vp)
    {
        SceneManager.LoadScene(sceneName: "2nd Floor Scene");
    }

    public bool Inside
    {
        get
        {
            return _inside;
        }

        set
        {
            _inside = value;
        }
    }

    public bool Solved
    {
        get
        {
            return _solved;
        }

        set
        {
            _solved = value;
        }
    }

    public int Counter
    {
        get
        {
            return _counter;
        }

        set
        {
            _counter = _counter + 1;
        }
    }
}
