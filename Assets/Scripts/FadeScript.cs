using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeScript : MonoBehaviour {

	public float fadeTime;
	private static bool playedOnce = false;
	private Image fadePanel;
	private Color currentColor = Color.black;

	// Use this for initialization
	void Start () {
		fadePanel = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad < fadeTime && !playedOnce) {
			float proportion = Time.deltaTime/fadeTime;
			currentColor.a -= proportion;
			fadePanel.color = currentColor;
			if(currentColor.a <= 0) { 
				playedOnce = true;
			}
		} else {
			gameObject.SetActive(false);
		}
	}
}
