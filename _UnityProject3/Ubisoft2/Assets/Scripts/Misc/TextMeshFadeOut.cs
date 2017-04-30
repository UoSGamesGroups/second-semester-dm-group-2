using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMeshFadeOut : MonoBehaviour {


	TextMesh text;

	void Awake()
	{
		text = GetComponent<TextMesh>();
	}

	void Update()
	{
		transform.position += Time.deltaTime * Vector3.up * 2;
		if(text.color.a > 0)
		{
			text.color -= new Color(0,0,0,1) * Time.deltaTime;
		}
		else
		{
			Destroy(gameObject);
		}
	}
}
