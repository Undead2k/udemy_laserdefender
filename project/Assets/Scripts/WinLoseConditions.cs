using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WinLoseConditions : MonoBehaviour {

	private GameObject textWin;
	private GameObject textLose;


	private ScoreKeeper sk;


	
	// Use this for initialization
	void Start () {


		sk = GameObject.Find ("ScoreKeeper").GetComponent<ScoreKeeper> ();


		textWin = GameObject.Find ("Win");
		textLose = GameObject.Find ("Lose");

		textWin.SetActive(false);
		textLose.SetActive(false);
	}

	void Update(){

	}

	public void Win (){
		textWin.SetActive(true);

	}

	public void Lose (){
		textLose.SetActive (true);
		sk.Highscore ();


	
	}

	public void Reset_WinLose(){
		//textWin.SetActive(false);
		//textLose.SetActive(false);
	}
}
