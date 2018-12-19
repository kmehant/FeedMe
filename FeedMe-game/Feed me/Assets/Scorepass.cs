using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Scorepass : MonoBehaviour {
	public Text score, hi; 
	int scores ;
	int a,b;
	// Use this for initialization
	void Start () {
		scores = PlayerPrefs.GetInt("Score");
		a = PlayerPrefs.GetInt ("h");
		b = PlayerPrefs.GetInt ("Score");
	}
	
	// Update is called once per frame
	void Update () {
		if (b>=a){
			PlayerPrefs.SetInt("h",b);

		}
		hi.text = "Your best score: " + PlayerPrefs.GetInt ("h");
		score.text = "Score: "+scores.ToString ();
	}
}
