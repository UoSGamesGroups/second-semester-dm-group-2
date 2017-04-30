using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBuilding : MonoBehaviour {

	[SerializeField] GameObject building;
	[SerializeField] TextMesh text;
	[SerializeField] string _tag;
	[SerializeField] int buildingPrice = 500;
	Vector2 mousePos;
	MoneyController moneyController;

	void Awake()
	{
		moneyController = GameObject.FindGameObjectWithTag(_tag).GetComponent<MoneyController>();
	}

	public void InsBuilding()
	{
		Instantiate(text, transform.position, transform.rotation);
		if(moneyController.Money>=buildingPrice)
		{
			Instantiate(building, Input.mousePosition, transform.rotation);
			moneyController.Money -= buildingPrice;
		}
	}
}
