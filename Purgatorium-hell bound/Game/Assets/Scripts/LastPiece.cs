using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastPiece : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject door1 = GameObject.Find("Dinning Room Door/Door_01");
        GameObject door2 = GameObject.Find("Dinning Room Door (1)/Door_01");

        bool open1 = door1.GetComponent<door>().Open;
        bool open2 = door2.GetComponent<door>().Open;

        GameObject player = GameObject.Find("/Player");
        bool havePiece = player.GetComponent<InventoryManager>().InventoryHas("LastPiece");

        if ((open1 == true || open2 == true) && havePiece == false)
        {
            GameObject lastPiece = GameObject.Find("solve puzzle frame/group_0/group_1/LastPiece");
            lastPiece.SetActive(true);
        }
    }
}
