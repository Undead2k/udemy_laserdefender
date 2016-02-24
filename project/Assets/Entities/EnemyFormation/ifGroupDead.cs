using UnityEngine;
using System.Collections;

public class ifGroupDead : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		if (AllMembersDead()) {
			Destroy(gameObject);
		}
	}


	bool AllMembersDead(){
		
		foreach (Transform childPositionGameObject in transform) {
			//Debug.Log (childPositionGameObject.childCount);
			if (childPositionGameObject.childCount > 0) {
				return false;
			}
		}
		return true;
	}


}
