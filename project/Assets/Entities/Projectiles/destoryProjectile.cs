using UnityEngine;
using System.Collections;

public class destoryProjectile : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll){
		Projectile bullet = coll.gameObject.GetComponent<Projectile> ();

		if (bullet){

			Destroy (coll.gameObject);

	}

}
}