using UnityEngine;
using System.Collections;

public class destroyShip : MonoBehaviour {




	void OnTriggerEnter2D(Collider2D coll){
		
		Projectile bullet = coll.gameObject.GetComponent<Projectile> ();
		
		if (bullet) {
			Debug.Log ("HELLO");
			e_ship_stats shipStats = GetComponent<e_ship_stats>();


			Debug.Log (shipStats.health);

			shipStats.health -= 1f;
			
			if (shipStats.health <= 0f) {
				Destroy (gameObject);
			}
			

		}
		
	}
}
