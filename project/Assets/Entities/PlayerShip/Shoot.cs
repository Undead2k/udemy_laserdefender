using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public Rigidbody2D bullet;
	public float fireRate = 0.05f;

	private SoundFX sfx;

	void Start(){
		sfx = GameObject.Find ("SoundFX").GetComponent<SoundFX> ();
	}
	// Update is called once per frame
	void Update () {
		FireLaser_Control ();

	
	}

	void FireLaser_Control(){
		
		if (Input.GetButtonDown ("Fire1")) {
			InvokeRepeating("FireLaser_method", 0.000001f, fireRate);
		}
		if (Input.GetButtonUp ("Fire1")) {
			CancelInvoke("FireLaser_method");
		}
		
	}
	
	void FireLaser_method(){
		Instantiate (bullet, transform.position, transform.rotation);
		sfx.sfx_PlayerShoot1 ();
	}

}
