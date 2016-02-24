using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WinLoseConditions : MonoBehaviour {

	private GameObject textWin;
	private GameObject textLose;

	private LevelManager levelManager;
	private playerShip_stats player;


	
	// Use this for initialization
	void Start () {

		levelManager = GameObject.Find ("LevelManager").GetComponent<LevelManager> ();
		player = GameObject.Find ("Player_Ship_1").GetComponent<playerShip_stats> ();



		textWin = GameObject.Find ("Win");
		textLose = GameObject.Find ("Lose");

		textWin.SetActive(false);
		textLose.SetActive(false);
	}

	void Update(){
		if (player.isPlayerAlive == false) {
			if (Input.GetKey ("space")) {
				levelManager.LoadLevel("Game");
			}
		}
	}

	public void Win (){
		textWin.SetActive(true);

		if (Input.GetKey ("up")) {
			levelManager.ResetLevel();
		}
	}

	public void Lose (){
			textLose.SetActive (true);

	
	}

	public void Reset_WinLose(){
		//textWin.SetActive(false);
		//textLose.SetActive(false);
	}
}
