using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tableFrameInteract : MonoBehaviour {
    private bool used = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
    }

    public void OnInteraction(Vector3 point)
    {
        
    }

    public void OnInteractionWithItem(InventoryManager i)
    {
        if (used == false) {
            // player have pedaço 1
            if (i.InventoryHas("Pedaço 1"))
            {
                GameObject pedaço1 = GameObject.Find("puzzle table frame/img/Pedaço 1").gameObject;
                pedaço1.SetActive(true);

            }
            // player have pedaço 2
            if (i.InventoryHas("Pedaço 2"))
            {
                GameObject pedaço2 = GameObject.Find("puzzle table frame/img/Pedaço 2").gameObject;
                pedaço2.SetActive(true);
            }
            // player have pedaço 3
            if (i.InventoryHas("Pedaço 3"))
            {
                GameObject pedaço3 = GameObject.Find("puzzle table frame/img/Pedaço 3").gameObject;
                pedaço3.SetActive(true);
            }
            // player have pedaço 4
            if (i.InventoryHas("Pedaço 4"))
            {
                GameObject pedaço4 = GameObject.Find("puzzle table frame/img/Pedaço 4").gameObject;
                pedaço4.SetActive(true);
            }

            GameObject pedaço1Aux = GameObject.Find("puzzle table frame/img/Pedaço 1").gameObject;
            GameObject pedaço2Aux = GameObject.Find("puzzle table frame/img/Pedaço 2").gameObject;
            GameObject pedaço3Aux = GameObject.Find("puzzle table frame/img/Pedaço 3").gameObject;
            GameObject pedaço4Aux = GameObject.Find("puzzle table frame/img/Pedaço 4").gameObject;

            // se os 4 pedaços tiverem ativos
            if (pedaço1Aux.activeInHierarchy && pedaço2Aux.activeInHierarchy
                && pedaço3Aux.activeInHierarchy && pedaço4Aux.activeInHierarchy)
            {
                Transform puzzle = GameObject.Find("puzzle table frame").transform;
                foreach (Transform child in puzzle)
                {

                    if (child.gameObject.name == "key")
                    {
                        child.gameObject.SetActive(true);

                    }

                }

                this.gameObject.layer = 0;
                used = true;
            }
            else
            {
                GameObject player = GameObject.Find("Player");
                player.GetComponent<NotificationScript>().OnNotify("I must find all the pieces of the picture has she told me to");
            }
        }
        
    }
}
