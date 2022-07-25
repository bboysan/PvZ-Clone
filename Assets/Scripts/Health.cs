using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	public float hitpoints = 100f;

	public void DealDamage(float damage) {
		hitpoints -= damage;
		if (hitpoints <= 0) {
			//TODO put animation here
			Die();
		}
	}

	public void Die() {
		Destroy(gameObject);
	}
}