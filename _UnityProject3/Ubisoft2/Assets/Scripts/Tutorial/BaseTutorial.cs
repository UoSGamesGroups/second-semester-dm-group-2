using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTutorial : MonoBehaviour {

	
	[SerializeField] GameObject hand;
	[SerializeField] GameObject trail;

	[SerializeField] GameObject controller;




	/// <summary>
	/// OnMouseDown is called when the user has pressed the mouse button while
	/// over the GUIElement or Collider.
	/// </summary>
	void OnMouseDown()
	{
			hand.gameObject.SetActive(false);
			trail.gameObject.SetActive(true);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "BaseTutorial" )
		{
			trail.gameObject.SetActive(false);
			controller.gameObject.SetActive(true);
		}
	}





}
