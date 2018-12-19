using UnityEngine;
using System.Collections;

public class startingload : MonoBehaviour {
	public double tt , st;
	// Use this for initialization
	void Start () {
		st = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		tt = Time.time - st;
		if (tt >= 6)
		{
			Application.LoadLevel(1);
		}
	}
}
