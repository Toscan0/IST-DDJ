using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkQuadroEletrico : MonoBehaviour {
    //lights to turn on
    public GameObject[] lights;
    public GameObject[] doors;

    AudioSource audio;
    public AudioClip _eletricidade;

    private bool f1 = false;
    private bool f2 = false;
    private bool f3 = false;
    private bool f4 = false;
    private bool f5 = false;
    private bool f6 = false;
    private bool f7 = false;
    private bool done = false;

    private Light myLight;
    void Start()
    {
        audio = GetComponent<AudioSource>();
        
    }

    void turnOn()
    {
        audio.PlayOneShot(_eletricidade, 2);
        foreach (GameObject light in lights)
        {
            myLight = light.GetComponent<Light>();
            myLight.enabled = true;
        }
        foreach (GameObject door in doors)
        {
            door.GetComponent<door>().Locked = false;
        }

        layerToDefault();  
    }

    void layerToDefault()
    {
        Transform fila_1 = GameObject.Find("puzzle quadro eletrico/fila (1)").transform;
        Transform fila_2 = GameObject.Find("puzzle quadro eletrico/fila (2)").transform;
        Transform fila_3 = GameObject.Find("puzzle quadro eletrico/fila (3)").transform;
        Transform fila_4 = GameObject.Find("puzzle quadro eletrico/fila (4)").transform;
        Transform fila_5 = GameObject.Find("puzzle quadro eletrico/fila (5)").transform;
        Transform fila_6 = GameObject.Find("puzzle quadro eletrico/fila (6)").transform;
        Transform fila_7 = GameObject.Find("puzzle quadro eletrico/fila (7)").transform;

        foreach (Transform child in fila_1)
        {
            child.gameObject.layer = 0;
        }
        foreach (Transform child in fila_2)
        {
            child.gameObject.layer = 0;
        }
        foreach (Transform child in fila_3)
        {
            child.gameObject.layer = 0;
        }
        foreach (Transform child in fila_4)
        {
            child.gameObject.layer = 0;
        }
        foreach (Transform child in fila_5)
        {
            child.gameObject.layer = 0;
        }
        foreach (Transform child in fila_6)
        {
            child.gameObject.layer = 0;
        }
        foreach (Transform child in fila_7)
        {
            child.gameObject.layer = 0;
        }
    }
    
    // Update is called once per frame
    void Update () {
		if(done == false)
        {
            Transform fila_1 = GameObject.Find("puzzle quadro eletrico/fila (1)").transform;
            Transform fila_2 = GameObject.Find("puzzle quadro eletrico/fila (2)").transform;
            Transform fila_3 = GameObject.Find("puzzle quadro eletrico/fila (3)").transform;
            Transform fila_4 = GameObject.Find("puzzle quadro eletrico/fila (4)").transform;
            Transform fila_5 = GameObject.Find("puzzle quadro eletrico/fila (5)").transform;
            Transform fila_6 = GameObject.Find("puzzle quadro eletrico/fila (6)").transform;
            Transform fila_7 = GameObject.Find("puzzle quadro eletrico/fila (7)").transform;

            foreach (Transform child in fila_1)
            {
                if (child.GetComponent<rotatePiece>()._pos == child.GetComponent<rotatePiece>().Position)
                {
                    f1 = true;
                }
                else
                {
                    f1 = false;
                    /*Debug.Log(child.name + "\n" +
                        child.GetComponent<rotatePiece>()._pos + "   " +
                        child.GetComponent<rotatePiece>().Position);*/
                    break;
                }

            }
  
            foreach (Transform child in fila_2)
            {

                if (child.GetComponent<rotatePiece>()._pos == child.GetComponent<rotatePiece>().Position)
                {
                    f2 = true;
                }
                else
                {
                    /*
                    Debug.Log(child.name + "\n" +
                        child.GetComponent<rotatePiece>()._pos + "   " +
                        child.GetComponent<rotatePiece>().Position);*/
                    f2 = false;
                    break;
                }

            }

            foreach (Transform child in fila_3)
            {

                if (child.GetComponent<rotatePiece>()._pos == child.GetComponent<rotatePiece>().Position)
                {
                    f3 = true;
                }
                else
                {
                    /*
                    Debug.Log(child.name + "\n" +
                        child.GetComponent<rotatePiece>()._pos + "   " +
                        child.GetComponent<rotatePiece>().Position);*/
                    f3 = false;
                    break;
                }

            }

            foreach (Transform child in fila_4)
            {

                if (child.GetComponent<rotatePiece>()._pos == child.GetComponent<rotatePiece>().Position)
                {
                    f4 = true;
                }
                else
                {
                    
                    /*Debug.Log(child.name + "\n" +
                        child.GetComponent<rotatePiece>()._pos + "   " +
                        child.GetComponent<rotatePiece>().Position);*/
                    f4 = false;
                    break;
                }

            }

            foreach (Transform child in fila_5)
            {

                if (child.GetComponent<rotatePiece>()._pos == child.GetComponent<rotatePiece>().Position)
                {
                    f5 = true;
                }
                else
                {
                    /*Debug.Log(child.name + "\n" +
                        child.GetComponent<rotatePiece>()._pos + "   " +
                        child.GetComponent<rotatePiece>().Position);*/
                    f5 = false;
                    break;
                }

            }

            foreach (Transform child in fila_6)
            {

                if (child.GetComponent<rotatePiece>()._pos == child.GetComponent<rotatePiece>().Position)
                {
                    f6 = true;
                }
                else
                {
                    /*Debug.Log(child.name + "\n" +
                        child.GetComponent<rotatePiece>()._pos + "   " +
                        child.GetComponent<rotatePiece>().Position);*/
                    f6 = false;
                    break;
                }

            }

            foreach (Transform child in fila_7)
            {

                if (child.GetComponent<rotatePiece>()._pos == child.GetComponent<rotatePiece>().Position)
                {
                    f7 = true;
                }
                else
                {
                    /*Debug.Log(child.name + "\n" +
                        child.GetComponent<rotatePiece>()._pos + "   " +
                        child.GetComponent<rotatePiece>().Position);*/
                    f7 = false;
                    break;
                }

            }

            if (f1 == true && f2 == true && f3 == true && f4 == true && f5 == true  && f6 == true && f7 == true)
            {
                //Debug.Log("Diiiiiiiiiiiiiiiiiiiiiim");
                done = true;
                turnOn();
            }
            
        }
	}

    public bool Done
    {
        get
        {
            return done;
        }

        set
        {
            done = value;
        }
    }
}
