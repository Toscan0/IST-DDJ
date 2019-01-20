using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {


	public void Playgame ()
	{
		SceneManager.LoadScene(sceneName: "1st Floor Scene");
	}
	
	public void QuitGame ()
	{
		
		Application.Quit();
	}



	// Use this for initialization
	//void Start () {
		
	//}
	
	// Update is called once per frame
	//void Update () {
		
	//}
}
