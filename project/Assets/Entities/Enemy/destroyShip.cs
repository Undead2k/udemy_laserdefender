using UnityEngine;
using System.Collections;

public class destroyShip : MonoBehaviour {

	private ScoreKeeper scoreKeeper;

	void Start(){
		scoreKeeper = GameObject.Find ("ScoreKeeper").GetComponent<ScoreKeeper> ();
	}

	void OnTriggerEnter2D(Collider2D coll){

		PlayerProjectile bullet = coll.gameObject.GetComponent<PlayerProjectile> ();
				
		if (bullet) {

			e_ship_stats shipStats = GetComponent<e_ship_stats>();

			shipStats.health -= bullet.GetDamage();
			bullet.Hit();
			if (shipStats.health <= 0f) {
				scoreKeeper.Score(shipStats.points);
				Destroy (gameObject);
			}
		}
	}
}
