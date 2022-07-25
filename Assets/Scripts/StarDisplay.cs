using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StarDisplay : MonoBehaviour {

	Text starCount;
	int count = 100;
	public enum Status {SUCCESS, FAILURE};

	void Start () {
		starCount = GetComponent<Text> ();
		starCount.text = count.ToString ();
	}

	public void AddToUI (int amount) {
		count += amount;
		starCount.text = count.ToString();
	}

	public Status SpendStars(int amount) {
		if (count >= amount) {
			count -= amount;
			starCount.text = count.ToString ();
			return Status.SUCCESS;
		}
		return Status.FAILURE;
	}
}
