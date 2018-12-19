using UnityEngine;
using System.Collections;

public class playscripton : MonoBehaviour {
	public GameObject resume;
	public GameObject pups;
	public GameObject[] gameobjects, getna;
	public int a ;
	void Start ()
	{a = 0;
		Time.timeScale = 1;
	}
	public void pause()
	{
		getna = GameObject.FindGameObjectsWithTag ("hit");
		gameobjects = GameObject.FindGameObjectsWithTag ("tile1");
		for (int i =0;i<gameobjects.Length;i++)
		{
			Destroy(gameobjects[i]);
		}
		
		for (int i =0;i<getna.Length;i++)
		{
			Destroy(getna[i]);
		}
		Time.timeScale = 0;
		resume.SetActive (true);

	}
	public void showpups()
	{
		if (a == 0 ){
			getna = GameObject.FindGameObjectsWithTag ("hit");
			gameobjects = GameObject.FindGameObjectsWithTag ("tile1");
			for (int i =0;i<gameobjects.Length;i++)
			{
				Destroy(gameobjects[i]);
			}
			
			for (int i =0;i<getna.Length;i++)
			{
				Destroy(getna[i]);
			}
			a =1;
			pups.SetActive(true);
			Time.timeScale =0;
		}
		else if (a == 1){
			a =0;
			pups.SetActive(false);
			Time.timeScale =1;
		}
	}
	public void resumegame()
	{
		resume.SetActive (false);
		Time.timeScale = 1;

	}
	public void quitgame()
	{
		Application.Quit ();
	}

	public void replaygame()
	{
		Time.timeScale = 1;
		Application.LoadLevel (2);
	}
	public void menugame()
	{
		Time.timeScale = 1;
		Application.LoadLevel (0);
	}
}
