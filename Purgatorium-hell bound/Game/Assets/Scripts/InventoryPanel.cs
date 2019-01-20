using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPanel : MonoBehaviour {
    Animator m_Animator;
    bool currentState = false; //TRUE = open, FALSE= closed
    public GameObject _itemprefab;
    public List<GameObject> _itemsDrawn;
    // Use this for initialization
    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update () {
		
	}
    public void OnInvDown()
    {
        if (!currentState)
        {
            m_Animator.CrossFade("enter", 1);
            currentState = true;
        }
        else if (currentState)
        {
            m_Animator.CrossFade("exit", 1);
            currentState = false;
        }

    }

    public void OnInvOut()
    {
        if (currentState)
            m_Animator.CrossFade("exit", 1);
        currentState = false;
    }
    public void  Updatelayout(Dictionary<string, GameObject> d)
    {
        foreach (GameObject g in _itemsDrawn)
            Destroy(g);
        int offset = 0;
        foreach (KeyValuePair<string, GameObject> t in d)
        {
            GameObject i = (GameObject)Instantiate(_itemprefab);
            i.transform.SetParent(this.transform,false);
            i.GetComponent<InventoryItemPrefab>().changeItemName(t.Key);
            i.GetComponent<InventoryItemPrefab>().changeItemDescription(t.Value.GetComponent<Item>()._description);
            i.transform.Translate(new Vector3(0, offset, 0));
            _itemsDrawn.Add(i);
            offset -= 35;
        }
    }
}
