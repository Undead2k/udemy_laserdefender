using UnityEngine;
using System.Collections;

public class destoryProjectile : MonoBehaviour {

void OnTriggerEnter(Collider col){
		Destroy (col.gameObject);
		print ("boom");
	}

	void OnTriggerEnter2D(Collider2D coll){
		Destroy (coll.gameObject);
		print ("YAY");
	}

}
