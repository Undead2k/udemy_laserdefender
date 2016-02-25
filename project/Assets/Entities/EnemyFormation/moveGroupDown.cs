using UnityEngine;
using System.Collections;

public class moveGroupDown : MonoBehaviour {

	private Vector3 group;
	public float speed = 1f;

	// Use this for initialization
	void Start () {
		group.x = this.transform.position.x;
		group.y = this.transform.position.y;
	}

	// Update is called once per frame
	void Update () {
	
		group.y -= speed * Time.deltaTime;

		this.transform.position = group;

		if (this.transform.position.y <= -12f) {
			Destroy(gameObject);
		}
	}
}
