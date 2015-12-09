using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject laserPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		FireLaser_Control ();
	}

	void FireLaser_Control(){
		
		if (Input.GetButton ("Fire1")) {
			print("hello");
			
			FireLaser_method();
			
		}
		
	}
	
	void FireLaser_method(){
		Vector3 thePosition = transform.TransformPoint(0, 0, 0);
		GameObject laser = Instantiate (laserPrefab, thePosition, Quaternion.identity) as GameObject;
		laser.transform.parent = transform;
		

	}

}
