using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class scoresandcoins : MonoBehaviour {

	public Text a, b, c, d, coinstext;
	public int a1;
	public int snailscore, twoscore, threescore , heartscore;
	public GameObject cannot;
	void Start ()
	{

		a.text = "Left: "+ PlayerPrefs.GetInt ("snail").ToString();
		b.text = "Left: "+ PlayerPrefs.GetInt ("three").ToString();
		c.text = "Left: "+ PlayerPrefs.GetInt ("heart").ToString();
		d.text = "Left: "+ PlayerPrefs.GetInt ("two").ToString();
		 a1 = PlayerPrefs.GetInt ("coins");
	}
	public void Okay1()
	{
		cannot.SetActive (false);
	}
	public void snail ()
	{
		a1 = PlayerPrefs.GetInt ("coins");
		if ( a1 < 1000) {
			cannot.SetActive (true);
		} 
		else if (a1>=1000) {

			snailscore = PlayerPrefs.GetInt("coins");
			snailscore = snailscore-1000;
			PlayerPrefs.SetInt("coins",snailscore);
			coinstext.text = "Coins you have: "+snailscore.ToString();
			int khan;
			khan = PlayerPrefs.GetInt("snail");
			khan = khan +1;
			PlayerPrefs.SetInt("snail",khan);
			a.text = "Left: "+ PlayerPrefs.GetInt ("snail").ToString();
		}

	}

	public void two()
	{
		a1 = PlayerPrefs.GetInt ("coins");
		if (a1 < 500) {
			cannot.SetActive (true);
		} else if (a1 >= 500) {
			twoscore = PlayerPrefs.GetInt("coins");
			twoscore = twoscore-500;
			PlayerPrefs.SetInt("coins",twoscore);
			coinstext.text = "Coins you have: "+twoscore.ToString();
			int khan;
			khan = PlayerPrefs.GetInt("two");
			khan = khan +1;
			PlayerPrefs.SetInt("two",khan);
			d.text = "Left: "+ PlayerPrefs.GetInt ("two").ToString();
		}
	}

	public void threes()
	{
		a1 = PlayerPrefs.GetInt ("coins");
		if (a1 < 700) {
			cannot.SetActive (true);
		} else if (a1 >= 700) {
			threescore = PlayerPrefs.GetInt("coins");
			threescore= threescore-700;
			PlayerPrefs.SetInt("coins",threescore);
			coinstext.text = "Coins you have: "+threescore.ToString();
			int khan;
			khan = PlayerPrefs.GetInt("three");
			khan = khan +1;
			PlayerPrefs.SetInt("three",khan);
			b.text = "Left: "+ PlayerPrefs.GetInt ("three").ToString();
		}
	}

	public void heartt()
	{
		a1 = PlayerPrefs.GetInt ("coins");
		if (a1 < 800) {
			cannot.SetActive (true);
		} else if (a1 >= 800) {
			heartscore = PlayerPrefs.GetInt("coins");
			heartscore= heartscore-800;
			PlayerPrefs.SetInt("coins",heartscore);
			coinstext.text = "Coins you have: "+heartscore.ToString();
			int khan;
			khan = PlayerPrefs.GetInt("heart");
			khan = khan +1;
			PlayerPrefs.SetInt("heart",khan);
			c.text = "Left: "+ PlayerPrefs.GetInt ("heart").ToString();
		}
	}
}
