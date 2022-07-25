using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

	private float walkSpeed;
	public float frequency;
	private GameObject currentTarget;
	private Animator anim;

	// Use this for initialization
	void Start () {
		Rigidbody2D rb = gameObject.AddComponent<Rigidbody2D> ();
		rb.isKinematic = true;
		anim = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * walkSpeed * Time.deltaTime);
		if (!currentTarget) {
			anim.SetBool ("IsAttacking", false);
		}
	}
	
	public void SetSpeed(float speed) {
		walkSpeed = speed;
	}

	public void StrikeCurrentTarget(float damage) {
		if (currentTarget) {
			Debug.Log (name + " did " + damage + " damage!");
			currentTarget.GetComponent<Health> ().DealDamage (damage);
		}
	}

	public void Attack(GameObject target) {
		currentTarget = target;
	}
}
