using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiplier : MonoBehaviour {

	
	public static int multiplierStreak = 0;
	

	public static int ApplyScore(bool isReseting = false)
	{
		int scorePotency = 50;
		scorePotency *= multiplierStreak;

		if(isReseting)
		{
			multiplierStreak = 0;
		}

		return scorePotency;
	}




}
