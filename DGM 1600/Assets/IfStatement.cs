using UnityEngine;
using System.Collections;

public class IfStatement : MonoBehaviour
{
	public float Lemmingpopulation = 100.0f;
	public float Toomanylemmings = 70.0f;
	public float Lemmingsaredying = 30.0f;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space))
			Lemmingtest ();

		Lemmingpopulation -= Time.deltaTime * 5f;
	}


	void Lemmingtest ()
	{
		if (Lemmingpopulation > Toomanylemmings)
		{
			print ("Too many lemmings.");
		} 
		else if (Lemmingpopulation < Lemmingsaredying) 
		{
			print ("Lemmings are dying.");
		}
		else
		{
			print ("Just enough Lemmings");
		}
	
	}
}
