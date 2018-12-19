using UnityEngine;
using System.Collections;

public class tiles : MonoBehaviour {
	public int speed;
	public double st , tt;
	// Use this for initialization
	void Start () {
		st = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		tt = Time.time - st;
		if (tt >= 5) {
			speed = Random.Range(10,20);
			GetComponent<Rigidbody2D>().gravityScale = speed;

		}
		if (tt >= 8) {
			Destroy(gameObject);
		}

	}
}
