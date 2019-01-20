using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class codeManager : MonoBehaviour
{
    public string code;
    public Text _text;
    public GameObject door;
    private string userTry = "";


    public void setUserTry(string n)
    {
        userTry = userTry + n;
        if (userTry.Length >= 4 && userTry != code)
        {
            userTry = "";
        }
        if (userTry == code)
        {
            Debug.Log("DIM DIM DIM");
            //open Door
            //GameObject door = GameObject.Find("Kitchen Door/Door_01").gameObject;
            door.GetComponent<door>().Locked = false;
        }
        Debug.Log("try: " + userTry);
        _text.text = userTry;
    }
}