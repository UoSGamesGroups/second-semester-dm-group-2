using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasTutorial : MonoBehaviour {

	
	[SerializeField] GameObject buildingTuto;
	[SerializeField] GameObject G_base;

	/// <summary>
	/// Sent when another object enters a trigger collider attached to this
	/// object (2D physics only).
	/// </summary>
	/// <param name="other">The other Collider2D involved in this collision.</param>
	void OnTriggerEnter2D(Collider2D other)
	{
			if(other.gameObject.tag == "Building")
			{
				buildingTuto.gameObject.SetActive(false);
				G_base.gameObject.SetActive(true);

				Time.timeScale = 1;
			}
	}



}
