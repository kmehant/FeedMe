using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class twotext : MonoBehaviour {
	public Text threetxt;
	// Use this for initialization
	void Start () {
		threetxt.text = "Left:"+PlayerPrefs.GetInt ("two").ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
