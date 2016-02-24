using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	public int score;
	private Text myText;
	private string scoreText = "Score: ";


	// Use this for initialization
	void Start () {
		myText = GameObject.Find ("Score").GetComponent<Text> ();
		score = 0;
		myText.text = scoreText + score.ToString ();

	}

	public void Score (int points){
		score += points;
		myText.text = scoreText + score.ToString ();
	}


	public void Reset(){
		score = 0;
		myText.text = scoreText + score.ToString ();
	}

}
