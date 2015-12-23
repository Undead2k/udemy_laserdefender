using UnityEngine;
using System.Collections;

public class moveForward : MonoBehaviour {

	float maxSpeed = 10f;

	void Update () {
	
		Vector3 pos = transform.position;

		Vector3 vel = new Vector3 (0, maxSpeed * Time.deltaTime, 0);

		pos += transform.rotation * vel;

		transform.position = pos;

	}




}
