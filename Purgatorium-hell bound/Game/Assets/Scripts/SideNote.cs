using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideNote : MonoBehaviour {
    Animator m_Animator;
    bool currentState = false;
    // Use this for initialization
    void Start () {
        m_Animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTabDown()
    {
        if(!currentState)
        {
            m_Animator.CrossFade("enter",1);
            currentState = true;
        }
        else if(currentState)
        {
            m_Animator.CrossFade("exit",1);
            currentState = false;
        }

    }

    public void OnTabOut()
    {if(currentState)
        m_Animator.CrossFade("exit", 1);
        currentState = false;
    }
}
