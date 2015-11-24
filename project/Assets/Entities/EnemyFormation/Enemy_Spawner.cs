using UnityEngine;
using System.Collections;

public class Enemy_Spawner : MonoBehaviour {

	public GameObject enemyPrefab;

	float width = 15f;
	float height = 10f;

	// Use this for initialization
	void Start () {


		foreach (Transform child in transform) {
		
			GameObject enemy = Instantiate (enemyPrefab, child.transform.position, Quaternion.identity) as GameObject;
			enemy.transform.parent = child;
		


		}
	}

	public void OnDrawGizmos(){

		Gizmos.DrawWireCube(transform.position, new Vector3(width, height, 0));

	}

	// Update is called once per frame
	void Update () {
	
	}
}
