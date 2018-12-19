using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class heartss : MonoBehaviour {
	public Text txt;
	// Use this for initialization
	void Start () {
		txt.text = "Left: " + PlayerPrefs.GetInt("heart") ;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
