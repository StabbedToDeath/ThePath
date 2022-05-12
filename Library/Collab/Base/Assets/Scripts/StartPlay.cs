using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlay : MonoBehaviour {
	//public Rigidbody2D player;
	//public GameObject[] levels = new GameObject[2];
	public static bool clear=false;
	public static int lno = 0;
	//public GameObject Demo;
	public GameObject menupanel;
	public GameObject gamepanel;
	public GameObject resultpanel;
	public GameObject optionspanel;
	public static GameObject tempPlayer;


	// Use this for initialization
	void Start () {
		//player = GetComponent<Rigidbody2D> ();
		//player.gravityScale = 0;

//		GameManager._instance.levels[lno].transform.GetChild(0).GetComponent<Rigidbody2D> ().gravityScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Collide.next == true) {
			if (ScoreManager._score >= 2) {
				menupanel.SetActive (false);
				gamepanel.SetActive (false);
				resultpanel.SetActive (true);
				ScoreManager._score = 0;
				Collide.next = false;
				Destroy (tempPlayer);
			} 
			else {
				Retry ();
			}
		}
	}
	public void OnButtonClick(GameObject _obj)
	{
		if (_obj.gameObject.name == "Play") {
			menupanel.SetActive (false);
			gamepanel.SetActive (true);
			optionspanel.SetActive (false);
			tempPlayer=GameManager._instance.LoadLevel();

		}
		if (_obj.gameObject.name == "Start")
		{
			
			tempPlayer.transform.GetChild(0).GetComponent<Rigidbody2D> ().gravityScale = 1;
		//	player.gravityScale = 1;
		}
		if (_obj.gameObject.name == "Retry") 
		{
			Retry ();
		}
		/*if (Collide.next == true) {
			menupanel.SetActive (false);
			gamepanel.SetActive (false);
			resultpanel.SetActive (true);
			Collide.next = false;
		}*/
		if (_obj.gameObject.name == "Nxt") {
			menupanel.SetActive (false);
			gamepanel.SetActive (true);
			resultpanel.SetActive (false);
			optionspanel.SetActive (false);
			tempPlayer=GameManager._instance.LoadLevel();
		}
		if (_obj.gameObject.name == "options") {
			menupanel.SetActive (false);
			gamepanel.SetActive (false);
			resultpanel.SetActive (false);
			optionspanel.SetActive (true);
		}

	}
	void Retry()
	{
		clear = true;
		menupanel.SetActive (false);
		gamepanel.SetActive (true);
		optionspanel.SetActive (false);
		Destroy (tempPlayer);
		ScoreManager._score = 0;
		tempPlayer=GameManager._instance.LoadLevel();
	}

 	
}
