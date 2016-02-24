using UnityEngine;
using System.Collections;


public class SoundFX : MonoBehaviour {


	public AudioSource sfx_player1_fireSound;
	public AudioClip testClip;

		public void Start(){

			//sfx_player1_fireSound = gameObject.AddComponent<AudioSource> ();
			//sfx_player1_fireSound.clip = Resources.Load ("SoundFX/sfx_laser1") as AudioClip;
			
	sfx_player1_fireSound = (AudioSource)gameObject.AddComponent ("AudioSource");
			
		testClip = (AudioClip) Resources.Load("SoundFX/sfx_laser1");

		sfx_player1_fireSound.clip = testClip;
		Debug.Log (testClip);
		Debug.Log (sfx_player1_fireSound);
			


		}

		public void sfx_PlayerShoot1(){

			sfx_player1_fireSound.Play ();

			//AudioSource.PlayClipAtPoint (player1_fireSound, transform.position);
		}




	}
