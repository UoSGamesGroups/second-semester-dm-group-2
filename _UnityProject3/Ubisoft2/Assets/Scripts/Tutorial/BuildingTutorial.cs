using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingTutorial : MonoBehaviour {

	[SerializeField] GameObject hand;
	[SerializeField] GameObject target;
	[SerializeField] GameObject G_base;
	[SerializeField] GameObject trajectory;



	void OnMouseDown()
	{
		hand.gameObject.SetActive(false);
		target.gameObject.SetActive(true);

	}






}
