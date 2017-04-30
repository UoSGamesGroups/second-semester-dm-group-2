using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGameOnClick : MonoBehaviour {

	[SerializeField] Color32 col1;
	[SerializeField] Color32 col2;
	[SerializeField]bool isTutorial;
	[SerializeField] GameObject fadeIn;
	[SerializeField] string sceneName;


	/// <summary>
	/// OnMouseDown is called when the user has pressed the mouse button while
	/// over the GUIElement or Collider.
	/// </summary>
	void OnMouseDown()
	{
		if(isTutorial)
		{
			GameController.globalScoreLeft=0;
			GameController.globalScoreRight=0;
		}
		fadeIn.GetComponent<FadeInFadeOut>().SceneName = sceneName;
		fadeIn.gameObject.SetActive(true);
	}

	void OnMouseEnter()
	{
		GetComponent<SpriteRenderer>().color = col2;
	}
	void OnMouseExit()
	{
		GetComponent<SpriteRenderer>().color = col1;
	}
}
