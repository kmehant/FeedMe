using UnityEngine;
using System.Collections;

public class play : MonoBehaviour {

	public void pUps()
	{
		Application.LoadLevel (5);
	}

	public void menugame()
	{
		Application.LoadLevel (1);
	}
	public void playgame()
	{
		Application.LoadLevel (2);
	}

	public void exitgame()
	{
		Application.Quit ();
	}
}
