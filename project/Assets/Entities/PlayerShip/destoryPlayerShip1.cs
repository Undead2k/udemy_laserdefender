using UnityEngine;
using System.Collections;

public class destoryPlayerShip1 : MonoBehaviour {

	private WinLoseConditions winLoseConditions;

	void OnTriggerEnter2D(Collider2D coll){

		EnemyProjectile bullet = coll.gameObject.GetComponent<EnemyProjectile> ();
		
		if (bullet) {
			winLoseConditions = GameObject.Find ("WinLoseConditions").GetComponent<WinLoseConditions> ();
			playerShip_stats playerStats = GetComponent<playerShip_stats>();
			
			
			Debug.Log (playerStats.health);
			
			playerStats.health -= bullet.GetDamage();
			
			if (playerStats.health <= 0f) {
				playerStats.isPlayerAlive = false;
				Destroy (gameObject);
				Debug.Log("GAMEOVER");
				Debug.Log(playerStats.isPlayerAlive);
				winLoseConditions.Lose();
			}

		}

		e_ship_stats eShip = coll.gameObject.GetComponent<e_ship_stats> ();
		
		if (eShip) {
			winLoseConditions = GameObject.Find ("WinLoseConditions").GetComponent<WinLoseConditions> ();
			playerShip_stats playerStats = GetComponent<playerShip_stats>();
			
			
			Debug.Log (playerStats.health);
			
			playerStats.health -= 1f;
			
			if (playerStats.health <= 0f) {
				playerStats.isPlayerAlive = false;
				Destroy (gameObject);
				Debug.Log("GAMEOVER");
				Debug.Log(playerStats.isPlayerAlive);
				winLoseConditions.Lose();
			}
		}
	}
}