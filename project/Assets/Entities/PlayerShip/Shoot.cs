using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public Rigidbody2D bullet;
	public float speed = 1f;
	public float fireRate = 0.1f;

	// Use this for initialization
	void Start () {
	
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
		Rigidbody2D laser = Instantiate (bullet, transform.position, transform.rotation) as Rigidbody2D;
		laser.velocity = new Vector3 (0, speed, 0);
	}

}
