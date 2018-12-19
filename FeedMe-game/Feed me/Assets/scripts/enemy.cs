using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class enemy : MonoBehaviour {



	void OnMouseDown()
	{
		int a = PlayerPrefs.GetInt ("indicator");
		if (a == 1){
			Destroy(this.gameObject);
			PlayerPrefs.SetInt("indicator",0);
		}
		else if (a == 0){
			Application.LoadLevel (4);
		}


	}
}