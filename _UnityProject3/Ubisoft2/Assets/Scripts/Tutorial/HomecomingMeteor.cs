using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomecomingMeteor : MonoBehaviour {


	bool isActive;
	GameObject G_base;

	void Update()
	{
		if(G_base==null)
			G_base = GameObject.FindGameObjectWithTag("Base_l");
		
		if(isActive)
		{
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			transform.position = Vector2.Lerp(transform.position, G_base.transform.position, Time.deltaTime * 2);
		}

	}

	// Use this for initialization
	/// <summary>
	/// Sent when an incoming collider makes contact with this object's
	/// collider (2D physics only).
	/// </summary>
	/// <param name="other">The Collision2D data associated with this collision.</param>
	void OnCollisionEnter2D(Collision2D other)
	{
			if(other.gameObject.tag == "Building")
			{
				StartCoroutine(ActivateHC());
			}
	}
	IEnumerator ActivateHC()
	{
		yield return new WaitForSeconds(1.5f);
		isActive = true;
	}
}
