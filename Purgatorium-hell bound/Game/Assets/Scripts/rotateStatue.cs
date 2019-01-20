using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateStatue : MonoBehaviour {
    AudioSource audio;
    public AudioClip _estatuaAMexer;
    private GameObject cavalo;
    private GameObject leao;
    private GameObject urso;
    private GameObject dragao;

    // Use this for initialization
    void Start () {
        cavalo = GameObject.Find("Lod_1").gameObject;
        leao = GameObject.Find("LionStatue").gameObject;
        urso = GameObject.Find("StatueBearLOD1").gameObject;
        dragao = GameObject.Find("TigerGargoyle-GO").gameObject;

    audio = leao.GetComponent<AudioSource>();
    }
	

    public void OnPickUp(GameObject player)
    {
        

        audio.PlayOneShot(_estatuaAMexer, 4);

        cavalo.transform.localEulerAngles = new Vector3(
            cavalo.transform.localEulerAngles.x,
            cavalo.transform.localEulerAngles.y + 90.0f,
            cavalo.transform.localEulerAngles.z);

        leao.transform.localEulerAngles = new Vector3(
            leao.transform.localEulerAngles.x,
            leao.transform.localEulerAngles.y - 45.0f,
            leao.transform.localEulerAngles.z);

        dragao.transform.localEulerAngles = new Vector3(
            dragao.transform.localEulerAngles.x,
            dragao.transform.localEulerAngles.y + 270,
            dragao.transform.localEulerAngles.z);

        urso.transform.localEulerAngles = new Vector3(
            urso.transform.localEulerAngles.x,
            urso.transform.localEulerAngles.y + 90.0f,
            urso.transform.localEulerAngles.z);

        
    }
   
}
