using UnityEngine;
using System.Collections;


public class SoundFX : MonoBehaviour {


	//Sources
	//Player Sounds
	public AudioSource sfx_player1_fireSound;
	public AudioSource sfx_player1_death;


	//Enemy Sounds
	public AudioSource sfx_enemy1_fireSound;
	public AudioSource sfx_enemy1_death;

	//Clips
	//Player
	public AudioClip player1_fireSound;
	public AudioClip player1_death;

	//Enemy
	public AudioClip enemy1_fireSound;
	public AudioClip enemy1_death;

	public void Start(){
		//Loading the audio to use later!
		//Sources
		//Player Sounds
		sfx_player1_fireSound = (AudioSource)gameObject.AddComponent ("AudioSource");
		sfx_player1_death = (AudioSource)gameObject.AddComponent ("AudioSource");

		//Enemy Sounds
		sfx_enemy1_fireSound = (AudioSource)gameObject.AddComponent ("AudioSource");
		sfx_enemy1_death = (AudioSource)gameObject.AddComponent ("AudioSource");

		//Clips
		//Player
		player1_fireSound = (AudioClip) Resources.Load("SoundFX/sfx_laser1");
		player1_death = (AudioClip) Resources.Load("SoundFX/SFX_Explosion_01");

		//Enemy
		enemy1_fireSound = (AudioClip) Resources.Load("SoundFX/sfx_laser2");
		enemy1_death = (AudioClip) Resources.Load("SoundFX/SFX_Explosion_02");




		//PLayer
		sfx_player1_fireSound.clip = player1_fireSound;
		sfx_player1_death.clip = player1_death;

		//Enemy
		sfx_enemy1_fireSound.clip = enemy1_fireSound;
		sfx_enemy1_death.clip = enemy1_death;
		


	}

	public void sfx_PlayerShoot1(){

		sfx_player1_fireSound.Play ();

	}

	public void sfx_PlayerDeath1(){
		
		sfx_player1_death.Play ();
		
	}

	public void sfx_EnemyShoot1(){
		
		sfx_enemy1_fireSound.Play ();
		

	}

	public void sfx_EnemyDeath1(){
		
		sfx_enemy1_death.Play ();
		
		
	}




	}
