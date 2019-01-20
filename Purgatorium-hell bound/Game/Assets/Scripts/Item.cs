using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
    public string _description;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPickUp(GameObject player)
    {
        Debug.Log("Got " + this.gameObject.name + ".");
        player.GetComponent<NotificationScript>().OnNotify("Got " + this.gameObject.name + ".");
        player.GetComponent<InventoryManager>().InventoryAdd(this.gameObject);
        this.gameObject.SetActive(false);
        Debug.Log("picked up");
    }
}
