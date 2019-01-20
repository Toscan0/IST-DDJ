using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour {
    public GameObject _owner;
    public Dictionary<string,GameObject> _currentInventory= new Dictionary<string, GameObject>();
    public Text _inventoryText;
    public InventoryPanel _inventoryPanel;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        string finaltext = "";
        foreach(KeyValuePair<string, GameObject> t in _currentInventory)
        {
            finaltext += t.Key + "\n";
        }
        _inventoryText.text = finaltext;
	}

    public void InventoryAdd(GameObject i)
    {
        _currentInventory.Add(i.name, i);
        _inventoryPanel.Updatelayout(_currentInventory);
    }
    public void InventoryRemove(GameObject i)
    {
        _currentInventory.Remove(i.name);
    }


    public bool InventoryHas(string s)
    {
        return _currentInventory.ContainsKey(s);
    }

    public GameObject GetInventoryPanel()
    {
        return _inventoryPanel.gameObject;
    }
}
