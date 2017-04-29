using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorBehaviour : MonoBehaviour {

	

	[SerializeField] Texture2D[] cursorImg; 


	void Start()
	{
		Cursor.SetCursor(cursorImg[0], Vector2.zero, CursorMode.Auto);
	}
	/// <summary>
	/// Update is called every frame, if the MonoBehaviour is enabled.
	/// </summary>
	void Update()
	{
			if(Input.GetKeyDown(KeyCode.Mouse0))
			{
				Cursor.SetCursor(cursorImg[1], Vector2.zero, CursorMode.Auto);
			}
			else if(Input.GetKeyUp(KeyCode.Mouse0))
			{
				Cursor.SetCursor(cursorImg[0], Vector2.zero, CursorMode.Auto);
			}
	}

}
