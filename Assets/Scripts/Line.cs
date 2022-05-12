using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour {

	public LineRenderer lineRend;
	public EdgeCollider2D edgecollide;
	List<Vector2> points;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void UpdateLine (Vector2 mousePos) {
		if (points == null) {
			points = new List<Vector2> ();
			SetPoint (mousePos);
			return;
		}
		if (Vector2.Distance (points.Last (), mousePos) > .1f)
			SetPoint (mousePos);	
	}



	void SetPoint(Vector2 point)
	{
		points.Add (point);
		lineRend.positionCount = points.Count;
		lineRend.SetPosition (points.Count - 1, point);
		if(points.Count > 1 )
			edgecollide.points = points.ToArray();
	}
}
