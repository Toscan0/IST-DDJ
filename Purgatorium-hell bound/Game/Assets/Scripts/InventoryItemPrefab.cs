using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemPrefab : MonoBehaviour {
    public Text _itemName;
    public Text _itemDescription;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void changeItemName(string t)
    {
        _itemName.text = t;
    }

    public void changeItemDescription(string t)
    {
        _itemDescription.text = t;
    }
}
