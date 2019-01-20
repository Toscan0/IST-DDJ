using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class FlickeringLight : MonoBehaviour {
    GameObject eltricidade;
    GameObject finalPuzzle;
    Light testLight;
	public float minWaitTime;
	public float maxWaitTime;
	
	void Start () {
        eltricidade = GameObject.Find("puzzle quadro eletrico").gameObject;
        finalPuzzle = GameObject.Find("FinalPuzzle").gameObject;

        testLight = GetComponent<Light>();
		StartCoroutine(Flashing());
	}
	
	IEnumerator Flashing ()
	{
       

        while (true)
		{
            yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
            if (eltricidade.GetComponent<checkQuadroEletrico>().Done == true &&
                finalPuzzle.GetComponent<LastPuzzle>().Solved == false)
            {
                testLight.enabled = !testLight.enabled;
            }        
		}
	}
}