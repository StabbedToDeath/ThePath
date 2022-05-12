using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultStars : MonoBehaviour {
	public GameObject star1;
	public GameObject star2;
	public GameObject star3;
	// Use this for initialization
	void Start () {
		star1.SetActive (false);
		star2.SetActive (false);
		star3.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (StartPlay.showstars == true) {
			Result ();
		}
		if (StartPlay.showstars == false) {
			Invoke ("Destroy", 0.0f);
		}
			
	}
	void Result()
	{
		Debug.Log ("in result");
		Debug.Log (StartPlay.temp);
		if (StartPlay.temp <=1) {
			Debug.Log ("LOL");
		}
		if (StartPlay.temp == 2) {
			star1.SetActive (true);
			star2.SetActive (true);
			star3.SetActive (false);
		}
		if (StartPlay.temp == 3) {
			star1.SetActive (true);
			star2.SetActive (true);
			star3.SetActive (true);
		}
	}
	void Destroy()
	{
		star1.SetActive (false);
		star2.SetActive (false);
		star3.SetActive (false);
	}
}
