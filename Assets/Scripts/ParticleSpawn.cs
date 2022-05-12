using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawn : MonoBehaviour {
	public GameObject particles;
	//public static GameObject particle;
	public static bool istouch = false;
	// Use this for initialization
	void Start () {
		particles.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (istouch == true) {
			Invoke ("Destroy", 1.0f);
			istouch = false;
		}
	}
	void OnTriggerEnter2D(Collider2D _object)
	{
		istouch = true;
		particles.SetActive (true);
	}
	void Destroy()
	{
		particles.SetActive (false);
	}
}
