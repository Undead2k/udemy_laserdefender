using UnityEngine;
using System.Collections;

public class destoryProjectile : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll){
		PlayerProjectile bullet = coll.gameObject.GetComponent<PlayerProjectile> ();
		EnemyProjectile bullet2 = coll.gameObject.GetComponent<EnemyProjectile> ();

		if (bullet){

			Destroy (coll.gameObject);

	}
		if (bullet2){
			
			Destroy (coll.gameObject);
			
		}

}
}