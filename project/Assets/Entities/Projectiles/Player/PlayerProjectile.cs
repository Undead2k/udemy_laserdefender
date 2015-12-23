using UnityEngine;
using System.Collections;

public class PlayerProjectile : MonoBehaviour {

	//standard laser
	public float laser_1_damage = 1f;


	public float GetDamage(){
		return laser_1_damage;
	}

	public void Hit(){
		Destroy (gameObject);
	}

}
