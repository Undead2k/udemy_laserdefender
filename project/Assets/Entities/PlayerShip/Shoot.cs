using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public Rigidbody bullet;
	public float speed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		FireLaser_Control ();
	}

	void FireLaser_Control(){
		
		if (Input.GetButton ("Fire1")) {

			FireLaser_method();
			
		}
		
	}
	
	void FireLaser_method(){
		Rigidbody laser = Instantiate (bullet, transform.position, transform.rotation) as Rigidbody;
		laser.AddForce (transform.up * speed, ForceMode.VelocityChange);
	}

}
