using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SlidingPuzzleTile : MonoBehaviour {
    public GameObject _root;
    public GameObject _player;
    public Firstlevelscenemanager _manager;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnInteraction(Vector3 point)
    {
        //SceneManager.LoadScene(sceneName: "SlidingTilePuzzle");
    }

    public void OnInteractionWithItem(InventoryManager i)
    {
        if (i.InventoryHas("LastPiece"))
        {

            SceneManager.LoadScene("SlidingTilePuzzle", LoadSceneMode.Additive);
            _manager.count++;
            SceneManager.MoveGameObjectToScene(_manager.gameObject, SceneManager.GetSceneByName("SlidingTilePuzzle"));
            this.gameObject.layer = 0;
        } else
        {
            GameObject player = GameObject.Find("Player");
            player.GetComponent<NotificationScript>().OnNotify("It's missing a piece, can't solve the puzzle without it"); 
        }
        
    }


    /*private void OnCollisionEnter(Collision collision){
       
        SceneManager.LoadScene("SlidingTilePuzzle",LoadSceneMode.Additive);
        _manager.count++;
        SceneManager.MoveGameObjectToScene(_manager.gameObject, SceneManager.GetSceneByName("SlidingTilePuzzle"));
    }*/
}
