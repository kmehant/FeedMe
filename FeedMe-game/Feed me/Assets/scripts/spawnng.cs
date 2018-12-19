using UnityEngine;
using System.Collections;

public class spawnng : MonoBehaviour {
	public GameObject tile1;
	public GameObject tile2;
	public double st, tt, ft, ttmain;
	public int n  ;
	public double sec;
	// Update is called once per frame

	void Start()
	{
		st = Time.time;
		ft = Time.time;
		sec = 4;
	}
	void Update () {
		tt = Time.time - st;
		ttmain = Time.time - ft;

		if(ttmain > 30 && ttmain<60)
		{
			sec = 3;
		}

		if(ttmain > 60 && ttmain<100)
		{
			sec = 2;
		}
		
		if(ttmain > 130 )
		{
			sec =1;
		}

		if(ttmain > 150 )
		{
			sec = 0.5;
		}





		if (tt >= sec) {
			n = Random.Range (1, 4);
		}
		if (n % 2 == 0) {
			if (tt >= sec) {
				Instantiate (tile1, this.transform.position, this.transform.rotation);
				st = Time.time;
			}
		} else {
			if (tt >= sec) {
				Instantiate (tile2, this.transform.position, this.transform.rotation);
				st = Time.time;
			}
		}
	}
}
