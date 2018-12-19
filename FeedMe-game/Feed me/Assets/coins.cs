using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class coins : MonoBehaviour {
	public Text textcoins;
	// Use this for initialization
	void Start () {
	
		int a = PlayerPrefs.GetInt ("coins");
		//PlayerPrefs.SetInt ("coins",0);
		textcoins.text = "Coins you have: " +a.ToString ();
	}
	

}
