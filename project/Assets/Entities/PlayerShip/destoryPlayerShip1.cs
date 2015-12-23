using UnityEngine;
using System.Collections;

public class destoryPlayerShip1 : MonoBehaviour {



	void OnTriggerEnter2D(Collider2D coll){
		
		EnemyProjectile bullet = coll.gameObject.GetComponent<EnemyProjectile> ();
		
		if (bullet) {
			playerShip_stats playerStats = GetComponent<playerShip_stats>();
			
			
			Debug.Log (playerStats.health);
			
			playerStats.health -= bullet.GetDamage();
			
			if (playerStats.health <= 0f) {
				playerStats.isPlayerAlive = false;
				Destroy (gameObject);
				Debug.Log("GAMEOVER");
				Debug.Log(playerStats.isPlayerAlive);
			}

		}

		e_ship_stats eShip = coll.gameObject.GetComponent<e_ship_stats> ();
		
		if (eShip) {
			playerShip_stats playerStats = GetComponent<playerShip_stats>();
			
			
			Debug.Log (playerStats.health);
			
			playerStats.health -= 1f;
			
			if (playerStats.health <= 0f) {
				playerStats.isPlayerAlive = false;
				Destroy (gameObject);
				Debug.Log("GAMEOVER");
				Debug.Log(playerStats.isPlayerAlive);
			}
		}
	}
}