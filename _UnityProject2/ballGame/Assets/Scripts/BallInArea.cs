using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInArea : MonoBehaviour {


	bool isActive;
	[SerializeField] MonoBehaviour _grayscale;
	[SerializeField] Controller _cont;

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "ball")
		{
			isActive = true;
		}
	}
	void OnTriggerExit(Collider col)
	{
		if(col.gameObject.tag == "ball")
		{
			isActive = false;
			_cont.counter = 3;
		}
	}


	// void Update()
	// {
	// 	if(!isActive)
	// 		_grayscale.enabled = true;
	// 	else
	// 		_grayscale.enabled = false;
	// }

}
