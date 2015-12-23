using UnityEngine;
using System.Collections;

public class EnemyShooter : MonoBehaviour {
	
	public Rigidbody2D bullet;
	public float fireRate = 0.05f;
	
	public bool TargetPlayer;





	
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		FireLaser_Control ();




	}
	
	void FireLaser_Control(){
		//playerShip_stats playerStats = GameObject.Find("Player_Ship_1").GetComponent<playerShip_stats>();

		float probability = Time.deltaTime * fireRate;

		Debug.Log (probability);
		Debug.Log (Random.value);
		if(Random.value < probability){
			FireLaser_method();
		}
		
	}
	
	void FireLaser_method(){
		Instantiate (bullet, transform.position, transform.rotation);

	}
	
}
