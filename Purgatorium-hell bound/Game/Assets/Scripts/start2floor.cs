using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start2floor : MonoBehaviour {
    public GameObject player;
	void Start () {
        player.GetComponent<InventoryManager>().InventoryAdd(this.gameObject);
        this.gameObject.SetActive(false);
    }
}
