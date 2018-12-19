using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class conu : MonoBehaviour {
	public Text counter;
	public double tt , st;
	// Use this for initialization
	void Start () {
		st = Time.time;

		}
	void Update()
	{
		tt = Time.time - st;
		if (tt <=1)
		{
			counter.text = "5";
		}
		
		if (tt>1 && tt<=2)
		{
			counter.text = "4";
		}
		if (tt>2 && tt<=3)
		{
			counter.text = "3";
		}
		if (tt>3 && tt<=4)
		{
			counter.text = "2";
		}
		if (tt > 4 && tt <= 4.5) {
			counter.text = "Get Ready";
		} 
		if(tt > 4.6){
			Time.timeScale = 1;
			Destroy(gameObject);
		}
	}

	void Impus()
	{

	}


}
