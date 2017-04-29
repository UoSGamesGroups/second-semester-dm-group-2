using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {


	

	[SerializeField] GameObject meteor;
	[SerializeField] GameObject target;
	[SerializeField] TextMesh text;
	[SerializeField] GameObject B_UI;
	[SerializeField] GameObject G_UI;
	bool isTimerStarting;

	GameObject B_Base;
	GameObject G_Base;

	[SerializeField] GameObject resetButton;
	// [SerializeField] int rPlayerMoney = 2000;
	// [SerializeField] int lPlayerMoney = 2000;

	static public int globalScoreRight = 0;
	static public int globalScoreLeft = 0;
	int position = 2;


	//check for meteors
	GameObject[] meteors;

	void Awake()
	{
		B_Base = GameObject.FindGameObjectWithTag("Base_r");
		G_Base = GameObject.FindGameObjectWithTag("Base_l");
	}

	IEnumerator Start()
	{
		while(true)
		{
			meteors = GameObject.FindGameObjectsWithTag("Meteor");
			yield return new WaitForSeconds(1f);
		}
		// InstantiateMeteorRight();
	}

	/// <summary>
	/// Update is called every frame, if the MonoBehaviour is enabled.
	/// </summary>
	void Update()
	{
			text.text = globalScoreLeft + "  -  " + globalScoreRight;
			CheckForMeteor();

			if(B_Base == null || G_Base == null)
			{
				resetButton.gameObject.SetActive(true);
			}
	}

	/// <summary>
	/// OnMouseUp is called when the user has released the mouse button.
	/// </summary>
	void OnMouseUp()
	{
			
		
			transform.localScale = new Vector2(0.7f, 0.7f );
			ChangePositionOnClick();
			GetComponent<BoxCollider2D>().enabled = false;
			GetComponent<SpriteRenderer>().enabled = false;
			
			ManipulateButton(false);
			
			if(position == 2)
			{
				InstantiateMeteorGreen();
				G_UI.gameObject.SetActive(true);
				B_UI.gameObject.SetActive(false);
				transform.position = new Vector2(7, 4);
				GetComponent<Animator>().SetBool("blue", true);
			}
			else 
			{
				InstantiateMeteorBlue();
				B_UI.gameObject.SetActive(true);
				G_UI.gameObject.SetActive(false);
				transform.position = new Vector2(-7, 4);
				GetComponent<Animator>().SetBool("blue", false);
			}
				meteors = GameObject.FindGameObjectsWithTag("Meteor");
	}

	/// <summary>
	/// OnMouseDown is called when the user has pressed the mouse button while
	/// over the GUIElement or Collider.
	/// </summary>
	void OnMouseDown()
	{
			transform.localScale = new Vector2(0.6f, 0.6f );
	}

	// public void RPlayerSpendsMoney(int amountSpent)
	// {
	// 	rPlayerMoney -= amountSpent;
	// }

	// public void LPlayerSpendsMoney(int amountSpent)
	// {
	// 	lPlayerMoney -= amountSpent;
	// }


	void InstantiateMeteorBlue()
	{
		target.transform.position = new Vector2(Random.Range(3f, 16f), -5);
		Instantiate(meteor, meteor.transform.position = new Vector2(Random.Range(0f, 12f),14f), transform.rotation);
	}

	void InstantiateMeteorGreen()
	{
		target.transform.position = new Vector2(Random.Range(-3f, -16f), -5);
		Instantiate(meteor, meteor.transform.position = new Vector2(Random.Range(0f, -12f),14f), transform.rotation);
	}

	void ManipulateButton(bool isActive)
	{
		GetComponent<BoxCollider2D>().enabled = isActive;
			GetComponent<SpriteRenderer>().enabled = isActive;
	}

	void ChangePositionOnClick()
	{
		if(position == 2)
		{
			position =1;
		}
		else
		{
			position = 2;
		}
	}


	void CheckForMeteor()
	{
		if(meteors.Length == 0)
		{
				ManipulateButton(true);
		}
	}


}
