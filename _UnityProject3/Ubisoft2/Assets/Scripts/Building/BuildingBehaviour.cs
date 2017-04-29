using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingBehaviour : MonoBehaviour {

	[SerializeField] ParticleSystem part;
	[SerializeField] GameObject lockPNG;
	[SerializeField] float force;
	[SerializeField]bool isHolding = true;
	public static bool isLocked = false;
	Vector2 pos;


	void Update()
	{
		if(!isLocked)
		{
			Hold();
			lockPNG.gameObject.SetActive(false);
		}
		else
		{
			lockPNG.gameObject.SetActive(true);
		}
	}

	void Hold()
	{
		if(Input.GetKeyUp(KeyCode.Mouse0))
		{
			isHolding = false;
		}

	
		if(isHolding)
		{
			pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			transform.position = pos;
		}
	}



	void OnMouseDown()
	{
		isHolding = true;
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.collider.tag == "Meteor")
		{
			part.transform.parent = null;
			part.Play();
			Vector2 direct = -transform.position + other.collider.transform.position;
			other.collider.GetComponent<Rigidbody2D>().AddForce(direct * force * Time.deltaTime,ForceMode2D.Impulse );
			Destroy(gameObject);
		}		
	}
	




}
