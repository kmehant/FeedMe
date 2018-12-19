using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class heary : MonoBehaviour {
	public Text txt;
	public GameObject panela;
	public void heart ()
	{

		int a = PlayerPrefs.GetInt ("heart");
		if (a>0){
			a--;
			PlayerPrefs.SetInt("heart",a);
			txt.text = "left: "+PlayerPrefs.GetInt("heart").ToString();
			PlayerPrefs.SetInt ("indicator",1);
			panela.SetActive(false);
			Time.timeScale =1;
		}
		else if (a<=0)
		{
			txt.text = "left: "+PlayerPrefs.GetInt("heart").ToString();
			PlayerPrefs.SetInt("indicator",0);
		}
	}
}
