using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class friend : MonoBehaviour {

	public bool a;
	public void Start()
	{
		a = false;
	}
	public void OnMouseDown()
	{
		a = true;

		Destroy (gameObject);
	
	}
}
