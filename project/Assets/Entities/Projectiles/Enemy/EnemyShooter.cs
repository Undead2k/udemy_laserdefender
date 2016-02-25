using UnityEngine;
using System.Collections;

public class EnemyShooter : MonoBehaviour {
	
	public Rigidbody2D bullet;
	public float fireRate = 0.05f;

	private SoundFX sfx;

	//feature for later
	public bool TargetPlayer;

	void Start(){
		sfx = GameObject.Find ("SoundFX").GetComponent<SoundFX> ();
	}

	// Update is called once per frame
	void Update () {
		FireLaser_Control ();
	}
	
	void FireLaser_Control(){
		float probability = Time.deltaTime * fireRate;

		if(Random.value < probability){
			FireLaser_method();
		}
		
	}
	
	void FireLaser_method(){
		Instantiate (bullet, transform.position, transform.rotation);
		sfx.sfx_EnemyShoot1 ();
	}
	
}
