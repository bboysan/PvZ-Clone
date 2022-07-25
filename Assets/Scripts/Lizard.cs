using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Attacker))]
public class Lizard : MonoBehaviour {
	
	private Attacker attacker;
	private Animator anim;
	
	void Start () {
		attacker = gameObject.GetComponent<Attacker> ();
		anim = gameObject.GetComponent<Animator> ();
	}
	
	void OnTriggerEnter2D(Collider2D col) {
		if (!col.GetComponent<Defender> ()) {
			return;
		}

		anim.SetBool ("IsAttacking", true);
		attacker.Attack(col.gameObject);
	}
}
