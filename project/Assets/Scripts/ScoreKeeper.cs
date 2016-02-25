using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	public static int score = 0;

	public static int highscore = 0;

	private Text txtScore;
	private Text txtHighscore;
	private Text txtScore2;
	private Text txtHighscore2;
	private string stringScore = "Score: ";
	private string stringHighscore = "Highscore: ";
	private string stringNew = " !! CONGRATS !! NEW HIGHSCORE !!";

	private Transform test;

	// Use this for initialization
	void Awake () {
		ResetScore ();

		txtScore = GameObject.Find ("Score").GetComponent<Text> ();
		txtHighscore = GameObject.Find ("Highscore").GetComponent<Text> ();

		txtScore2 = GameObject.Find ("Score2").GetComponent<Text> ();
		txtHighscore2 = GameObject.Find ("Highscore2").GetComponent<Text> ();


		txtScore.text = stringScore + score.ToString ();
		txtHighscore.text = stringHighscore + highscore.ToString ();
	}

	public void Score (int points){
		score += points;
		txtScore.text = stringScore + score.ToString ();
	}

	public void Highscore (){
		if (highscore < score) {
			highscore = score;

			txtHighscore.text = stringHighscore + highscore.ToString () + stringNew;



			txtScore2.text = stringScore + score.ToString ();
			txtHighscore2.text = stringHighscore + highscore.ToString ();

		} else {

			txtScore2.text = stringScore + score.ToString ();
			txtHighscore2.text = stringHighscore + highscore.ToString ();
			
		}
	}


	public void ResetScore(){
		score = 0;
		//myText.text = scoreText + score.ToString ();
	}

}
