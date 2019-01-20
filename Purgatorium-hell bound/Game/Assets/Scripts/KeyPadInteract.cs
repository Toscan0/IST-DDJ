using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPadInteract : MonoBehaviour
{
    public string number;
    public GameObject padLock;
    public void OnInteraction(Vector3 point)
    {
        Debug.Log("name: " + this.name + " " + number);
        //GameObject padLock = GameObject.Find("PadLock").gameObject;
        padLock.GetComponent<codeManager>().setUserTry(number);
    }
}