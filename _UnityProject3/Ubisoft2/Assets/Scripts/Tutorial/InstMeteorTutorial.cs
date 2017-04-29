using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstMeteorTutorial : MonoBehaviour {

	
	[SerializeField] GameObject meteor;
	[SerializeField] GameObject B_UI;

	bool isSlowTime = false;
	float temp = 1;

	/// <summary>
	/// OnMouseDown is called when the user has pressed the mouse button while
	/// over the GUIElement or Collider.
	/// </summary>
	void OnMouseDown()
	{
			meteor.gameObject.SetActive(true);
			GetComponent<BoxCollider2D>().enabled = false;
			GetComponent<SpriteRenderer>().enabled = false;
			B_UI.gameObject.SetActive(true);
			StartCoroutine(SlowTime());
	}


	IEnumerator SlowTime()
	{
		yield return new WaitForSeconds(5);
		isSlowTime = true;
	}

	void Update()
	{
		if(isSlowTime)
		{
			temp = Mathf.Lerp(temp, 0, Time.deltaTime * 4f);
			Time.timeScale = temp;
		}
	}

}
