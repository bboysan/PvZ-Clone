using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer : MonoBehaviour {

	Slider timer;
	private LevelManager levelManager;
	public float levelSeconds = 100;
	private bool levelEnd = false;
	private GameObject winLabel;

	void Start () {
		timer = GetComponent<Slider> ();
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
		winLabel = GameObject.Find ("Survived");
		winLabel.SetActive (false);
	}
	
	void Update () {
		timer.value = (Time.timeSinceLevelLoad / levelSeconds);
		if (Time.timeSinceLevelLoad >= levelSeconds && !levelEnd) {
			levelEnd = true;
			winLabel.SetActive(true);
			Invoke ("LoadNextLevel", 4f);
		}
	}

	void LoadNextLevel() {
		levelManager.LoadNextLevel ();
	}
}
