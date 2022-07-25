using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject projectile, spawnLocation;
	private GameObject projectileParent;
	private Animator anim;
	private SpawnScript spawner;

	void Start () {
		anim = GetComponent<Animator> ();
		projectileParent = GameObject.Find ("Projectiles");

		if (!projectileParent) {
			projectileParent = new GameObject("Projectiles");
		}

		SpawnScript[] spawnersInGame = GameObject.FindObjectsOfType<SpawnScript> ();
		foreach (SpawnScript spawner in spawnersInGame) {
			Debug.Log ("Spawner " + spawner.transform.position.y + " and transform is " + transform.position.y);
			if(spawner.transform.position.y == transform.position.y) {
				this.spawner = spawner;
			}
		}
	}

	void Update() {
		if (AttackerAhead ()) {
			anim.SetBool ("IsAttacking", true);
		} else {
			anim.SetBool("IsAttacking", false);
		}
	}


	bool AttackerAhead() {
		if (spawner.transform.childCount == 0) {
			return false;
		}

		foreach (Transform child in spawner.transform) {
			if(child.transform.position.x > transform.position.x) {
				return true;
			} 	
		}

		return false;
	}
	
	private void Fire() {
		GameObject newProjectile = Instantiate(projectile, spawnLocation.transform.position, Quaternion.identity) as GameObject;
		Debug.Log ("Spawning projectile " + projectile + " at " + spawnLocation.transform.position);
		newProjectile.transform.parent = projectileParent.transform;
	}
}
