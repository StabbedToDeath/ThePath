using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour {
	public static bool collect=false;
	public static bool next = false;
	//public AudioSource sound;
	//public GameObject particle;
	//public static bool complete = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	/*void OnCollisionEnter2D(Collision2D _object)
	{
		if (_object.gameObject.tag == "Star") {
			Destroy (_object.gameObject);
		}		
	}*/
	void OnTriggerEnter2D(Collider2D _object)
	{
		if (_object.gameObject.tag == "Star") {
			Destroy (_object.gameObject,0.5f);
			//Instantiate (particle);
			collect = true;
			//sound.Play ();
		}
		if (_object.gameObject.tag == "End") {
			//Debug.Log ("Reached");
			LineCreator.DeleteLines ();
			StartPlay.clear = true;
			if (ScoreManager._score >= 2) {
				StartPlay.lno++;
			} 
			Destroy (StartPlay.tempPlayer);
			next = true;
		}
			//GameManager._instance.LoadLevel ();

		if (_object.gameObject.tag == "Barrier") {
			LineCreator.DeleteLines ();
			Destroy (StartPlay.tempPlayer);
			StartPlay.tempPlayer=GameManager._instance.LoadLevel();
		}
	}
}
