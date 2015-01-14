using UnityEngine;
using System.Collections;

public class load : MonoBehaviour {
	//"traverseScreenScript"
	
	public int sceneToLoad;
	
	void onGUI() 
	     {
		GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height - 80, 100, 30), "Current Scene: " + (Application.loadedLevel + 1));
		if(GUI.Button(new Rect(Screen.width/ 2 - 50, Screen.height - 50, 100, 50), "Load Scene " + (sceneToLoad + 1)))
		{
			Application.LoadLevel(sceneToLoad);

			//PlayerPrefs.SetInt("health", 100);
			//int x = PlayerPrefs.GetInt("health");

		
	}
	
	
		
	}
}
