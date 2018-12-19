using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class coiner : MonoBehaviour {
	public Text txt;
	public Text tct;
	// Use this for initialization
	void Start () {
		txt.text = "Coins you have: " + PlayerPrefs.GetInt("coins").ToString();
		if (PlayerPrefs.GetInt("coins") == 0)
		{
			tct.text = "Gain more score to get more coins!";
		}
	}
	

}
