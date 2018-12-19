using UnityEngine;
using System.Collections;

public class buttoninteractive : MonoBehaviour {

	public bool a;
	void OnTriggerEnter()
	{
		a = true;
		transform.Translate(Vector3.up * 100); 
	}
}
