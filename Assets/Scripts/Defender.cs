using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour {
	public int cost = 100;
	private StarDisplay starDisplay;

	void Start() {
		starDisplay = GameObject.FindObjectOfType<StarDisplay> ();
	}

	public void AddStars(int amount) {
		starDisplay.AddToUI (amount);
	}
}
