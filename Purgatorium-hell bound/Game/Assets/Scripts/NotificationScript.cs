using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotificationScript : MonoBehaviour {
    public Text notification;
    Animator m_Animator;
    // Use this for initialization
    void Start()
    {
        notification.text = "";
        m_Animator = notification.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void Notify(string t)
    {
        notification.text = t;
    }

    public void OnNotify(string t)
    {
        notification.text = t;
        m_Animator.CrossFade("notification",1);
    }
}
