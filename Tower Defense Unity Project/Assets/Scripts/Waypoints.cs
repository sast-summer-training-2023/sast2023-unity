using UnityEngine;

public class Waypoints : MonoBehaviour {

	//Waypoints is added to every corner of the path to implement [Optional] 
	public static Transform[] points;

	void Awake ()
	{
		points = new Transform[transform.childCount];
		for (int i = 0; i < points.Length; i++)
		{
			points[i] = transform.GetChild(i);
		}
	}

}
