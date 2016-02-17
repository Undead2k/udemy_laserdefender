using UnityEngine;
using System.Collections;

public class Enemy_Spawner : MonoBehaviour {

	public GameObject enemyPrefab;

	float width = 1f;
	float height = 1f;

	// Use this for initialization
	void Start () {

		SpawnEnemy ();

	}

	public void OnDrawGizmos(){

		Gizmos.DrawWireCube(transform.position, new Vector3(width, height, 0));

	}

	// Update is called once per frame
	void Update () {
	
//		if (AllMembersDead ()) {
//			Debug.Log("all dead");
//			SpawnEnemy();
//		}

	}


	// Not good behaviour when used with the splines. Not what we want.
//	bool AllMembersDead(){
//
//		foreach (Transform childPositionGameObject in transform) {
//			//Debug.Log (childPositionGameObject.childCount);
//			if (childPositionGameObject.childCount > 0){
//				return false;
//			}
//		}
//		return true;
//
//	}

	void SpawnEnemy(){

		foreach (Transform child in transform) {
			
			GameObject enemy = Instantiate (enemyPrefab, child.transform.position, Quaternion.identity) as GameObject;
			enemy.transform.parent = child;
			
			
			
		}
	}
}
