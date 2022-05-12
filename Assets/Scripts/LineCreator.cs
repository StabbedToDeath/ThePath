using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCreator : MonoBehaviour {
	public GameObject line;
	public static ArrayList lines = new ArrayList ();
	GameObject lineGO;
	Line activeLine;

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			lineGO = Instantiate (line);
			lines.Add (lineGO);
			activeLine = lineGO.GetComponent<Line> ();
		}
		if (Input.GetMouseButtonUp (0)) {
			activeLine = null;
		}
		if (activeLine != null) {
			Vector2 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			activeLine.UpdateLine (mousePos);
		}
		if (StartPlay.clear == true) {
			DeleteLines ();
			StartPlay.clear = false;
		}
	}
	public static void DeleteLines()
	{
		foreach(GameObject lineGO in lines)
			Destroy (lineGO);
	}
}
