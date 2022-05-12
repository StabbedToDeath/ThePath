using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour {
	public Text Score;
	public static int _score=0;
	public AudioSource sound;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Collide.collect == true) {
			_score++;
			sound.Play ();
			Collide.collect = false;
		}
		/*if (Collide.next == true) {
			_score = 0;
		}*/
		Score.text = "Count:" + _score;
	}
}
