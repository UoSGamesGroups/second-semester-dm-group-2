using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyController : MonoBehaviour {

		public int Money = 5000;
	[SerializeField] TextMesh money;



	void Update()
	{
		money.text = Money.ToString("N0") + " £";
	}
}
