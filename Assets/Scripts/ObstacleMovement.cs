using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {
	float speed=0.25f;
	float random = 0.1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this.gameObject.tag == "Moving") {
			transform.Translate (Vector2.right * speed);
			if (transform.position.x > 1.4f)
				speed = -speed;
			if (transform.position.x < -1.5f)
				speed = -speed;
		}
		if (this.gameObject.tag == "Stretching")
		{
			if (transform.localScale.x <= -3.5f || transform.localScale.x >= 3.5f)
				random *= -1;
			transform.localScale += new Vector3 (random, 0.0f,0.0f);
	}
		if (this.gameObject.tag == "Clockwise") {
			transform.Rotate (Vector3.back);
		}
		if (this.gameObject.tag == "Anti") {
			transform.Rotate (Vector3.forward);
		}
}
}
