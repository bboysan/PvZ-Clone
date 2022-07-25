using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float waitTime;

	void Start () {
		if (waitTime != 0) {
			Invoke ("LoadNextLevel", waitTime);
		} 
	}

	public void LoadNextLevel() 
	{
		CancelInvoke("LoadNextLevel");
		Application.LoadLevel (Application.loadedLevel + 1);
	}

	public void LoadLevel(string name) 
	{
		if (name.Equals (null)) {
			Debug.Log ("Fix button linking.");
		} else {
			Application.LoadLevel (name);
		}
	}
}
