using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public GameObject[] levels = new GameObject[2];
	public static GameManager _instance;
	// Use this for initialization
	void Start ()
	{
		_instance = this;
	}

	public GameObject LoadLevel()
	{
		//Instantiate (levels [StartPlay.lno]);
		return  Instantiate(levels[StartPlay.lno]);
	}
	// Update is called once per frame

}
