using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {



	[SerializeField] TextMesh text;
	public float endTime;


	/// <summary>
	/// Update is called every frame, if the MonoBehaviour is enabled.
	/// </summary>
	void Update()
	{
			Timer_();
	}

	void Timer_()
	{
		if(endTime > 0)
		{
			endTime -= Time.deltaTime;
			text.text = endTime.ToString("N1");
		}
		else
		{
			text.text = string.Empty;
		}
	}



}
