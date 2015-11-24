using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Vector3 playerPos;

	public float speed = 0.2f;

	float clamp_minx;
	float clamp_maxx;
	float clamp_miny;
	float clamp_maxy;
	float padding = 0.5f;


	// Use this for initialization
	void Start () {
	
		playerPos = new Vector3 (0f, 0f, 0f);

		PlaySpaceBounderies ();

	}
	
	// Update is called once per frame
	void Update () {
		PlayerMover1 ();


	}

	void PlayerMover1(){
		
		if (Input.GetKey ("up")) {
			playerPos.y += speed * Time.deltaTime;
			
			
		}  if (Input.GetKey ("down")) {
			playerPos.y -= speed * Time.deltaTime;
			
			
		}  if (Input.GetKey ("left")) {
			playerPos.x -= speed * Time.deltaTime;
			
			
		}  if (Input.GetKey ("right")) {
			playerPos.x += speed * Time.deltaTime;
			
		} 
		
		this.transform.position = playerPos;
		
		RestrictPlayerMovement ();
		
	}

	void PlaySpaceBounderies(){

		float distance = transform.position.z - Camera.main.transform.position.z;

		Vector3 left = Camera.main.ViewportToWorldPoint (new Vector3 (0,0,distance));
		Vector3 right = Camera.main.ViewportToWorldPoint (new Vector3 (1,0,distance));
		Vector3 bottom = Camera.main.ViewportToWorldPoint (new Vector3 (0,0,distance));
		Vector3 top = Camera.main.ViewportToWorldPoint (new Vector3 (0,1,distance));
		
		clamp_minx = left.x + padding;
		clamp_maxx = right.x - padding;
		clamp_miny = bottom.y + padding;
		clamp_maxy = top.y - padding;
	}

	void RestrictPlayerMovement(){

		float wallX = Mathf.Clamp (playerPos.x, clamp_minx, clamp_maxx);
		float wallY = Mathf.Clamp (playerPos.y, clamp_miny, clamp_maxy);

		this.transform.position = new Vector3 (wallX, wallY, playerPos.z);

	}
	


}
