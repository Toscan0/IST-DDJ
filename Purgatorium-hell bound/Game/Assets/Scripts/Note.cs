using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{

    //[SerializeField] private Image customImage;
	public Transform image;

    public void OnInteraction(Vector3 point)
    {
        if (!image.gameObject.active)
            Camera.main.GetComponent<InputManager>()._state++;
		image.gameObject.SetActive(true);
    }

    public void OnClose()
    {
        if(image.gameObject.active)
            Camera.main.GetComponent<InputManager>()._state--;
        image.gameObject.SetActive(false);
        
    }

}
