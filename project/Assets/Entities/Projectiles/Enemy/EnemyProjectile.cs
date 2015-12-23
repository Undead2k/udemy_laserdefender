using UnityEngine;
using System.Collections;

public class EnemyProjectile : MonoBehaviour {
	
	//standard laser
	public float Laser = 1f;
	
	
	public float GetDamage(){
		return Laser;
	}
	
	public void Hit(){
		Destroy (gameObject);
	}
	
}
