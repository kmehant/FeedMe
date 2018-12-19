using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class pips : MonoBehaviour {
	public double timeleft = 10;
	public GameObject kan, jaj;
	public Text snailtxt;
	public bool a;

		public void snails()
	{
		int points = PlayerPrefs.GetInt ("snail");
		if (points > 0) {
			Time.timeScale = 0.25f;
			a = true;
			jaj.SetActive(false);
			StartCoroutine("waitforme");
		
		}

	}

	IEnumerator waitforme()
	{
		yield return new WaitForSeconds(10);
		can ();
	}

	void can ()
	{
		a = false;
		Time.timeScale = 1;
		int snails = PlayerPrefs.GetInt ("snail");
		if (snails <=0) {
			snails = 0;
			PlayerPrefs.SetInt ("snail", snails);
		} else {
			snails = snails - 1;
			PlayerPrefs.SetInt ("snail", snails);
		}
		snailtxt.text = "LEft: "+snails.ToString();
		kan.SetActive (true);
		for (int i =0;i<=10000;i++);
		kan.SetActive (false);
	}



}

