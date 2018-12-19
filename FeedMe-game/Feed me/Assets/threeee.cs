using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class threeee : MonoBehaviour {
	public Text threetxt;
	// Use this for initialization
	void Start () {
		threetxt.text = "Left:"+PlayerPrefs.GetInt ("three").ToString();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
