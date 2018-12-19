using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class score : MonoBehaviour {

	public GameObject hitme;
	public friend yourscore;
	public bool k;
	public int coins;
	public Text t;
	public int sc;
	void Start ()
	{

	}
	// Update is called once per frame
	void Update () {
		hitme = GameObject.FindGameObjectWithTag ("hit");
		yourscore = hitme.GetComponent<friend>();
		k = yourscore.a;
		if (k == true){

			sc++; 
			t.text = "Score:" + sc;
			PlayerPrefs.SetInt ("Score", sc);
			PlayerPrefs.Save ();
		}


	}
	void LateUpdate()
	{
		coins = sc;
	if (coins > 0 && coins <= 99) {
			coins = Mathf.RoundToInt (coins / 10);
		} else {
			coins = Mathf.RoundToInt (coins / 100);
		}

		PlayerPrefs.SetInt ("points", coins);
		int kel = PlayerPrefs.GetInt ("coins");
		PlayerPrefs.SetInt ("coins", kel + coins);
		PlayerPrefs.Save ();
	}
	int a  = 0;
	
	public Text txt;
	public GameObject ant;
	public void two ()
	{
		a = PlayerPrefs.GetInt ("two");
		if (a>0){
			
			int two1;
			two1 = PlayerPrefs.GetInt("two");
			two1--;
			ant.SetActive(false);
			PlayerPrefs.SetInt("two",two1);
			txt.text = "left: " + PlayerPrefs.GetInt("two").ToString();
			sc = sc*2;
			Time.timeScale =1;
		}
		else 
		if (a<=0){
			Time.timeScale =1;
			PlayerPrefs.SetInt("two",0);
			txt.text = "Left: " + PlayerPrefs.GetInt("two").ToString();
		}
	}

	int a1  = 0;
	
	public Text txt1;
	public GameObject ant1;
	public void three ()
	{
		a1 = PlayerPrefs.GetInt ("three");
		if (a1>0){
			
			int two1;
			two1 = PlayerPrefs.GetInt("three");
			two1--;
			ant.SetActive(false);
			PlayerPrefs.SetInt("three",two1);
			txt1.text = "left: " + PlayerPrefs.GetInt("three").ToString();
			sc = sc*3;
			Time.timeScale =1;
		}
		else 
		if (a<=0){
			Time.timeScale =1;
			PlayerPrefs.SetInt("three",0);
			txt1.text = "Left: " + PlayerPrefs.GetInt("three").ToString();
		}
	}

}
