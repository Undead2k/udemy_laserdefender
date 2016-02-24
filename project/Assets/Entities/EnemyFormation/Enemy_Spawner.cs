using UnityEngine;
using System.Collections;

public class Enemy_Spawner : MonoBehaviour {

	public GameObject[] enemyPrefab;
	public GameObject pos_withoutSpline;

	private WinLoseConditions winLoseConditions;

	float width = 1f;
	float height = 1f;

	public int wave = 0;

	public float spawnDelay = 0.5f;

	// Use this for initialization
	void Start () {

		winLoseConditions = GameObject.Find ("WinLoseConditions").GetComponent<WinLoseConditions> ();

		SpawnUntilFull ();

	}

	public void OnDrawGizmos(){

		Gizmos.DrawWireCube(transform.position, new Vector3(width, height, 0));

	}

	// Update is called once per frame
	void Update () {
	
		if (AllMembersDead ()) {
			Debug.Log("all dead");
			SpawnUntilFull();

		}
	}



	Transform NextFreePosition(){

		foreach (Transform childPositionGameObject in transform) {
			//Debug.Log (childPositionGameObject.childCount);
			if (childPositionGameObject.childCount == 0){
				return childPositionGameObject;
			}
		}


		return null;

	}

	// Not good behaviour when used with the splines. Not what we want.
	bool AllMembersDead(){

		foreach (Transform childPositionGameObject in transform) {
			//Debug.Log (childPositionGameObject.childCount);
			if (childPositionGameObject.childCount > 0){
				return false;
			}
		}

		wave += 1;

		if( wave > enemyPrefab.Length){

			winLoseConditions.Win ();
		}

		//			foreach (Transform parent in transform) {
		//
		//			Vector3 test = new Vector3(-2.5f, 0.5f,0f);
		//
		//				GameObject pos = Instantiate (pos_withoutSpline, test, Quaternion.identity) as GameObject;
		//				pos.transform.parent = parent;
		//
		//			}

		return true;

	}

	void SpawnUntilFull(){
		Transform freePosition = NextFreePosition ();

		if (freePosition) {

	

			GameObject enemy = Instantiate (enemyPrefab[wave], freePosition.position, Quaternion.identity) as GameObject;
			enemy.transform.parent = freePosition;

		} 

		if(NextFreePosition ()){

			Invoke ("SpawnUntilFull", spawnDelay);
		}

	}

//	void SpawnEnemy(){
//
//		foreach (Transform child in transform) {
//			
//			GameObject enemy = Instantiate (enemyPrefab, child.transform.position, Quaternion.identity) as GameObject;
//			enemy.transform.parent = child;
//			
//			
//			
//		}
//	}
}
