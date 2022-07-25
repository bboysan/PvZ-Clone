using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	private LevelManager levelManager;

	void Start() {
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}

	void OnTriggerEnter2D() {
		levelManager.LoadLevel ("GameOver");
	}
}
