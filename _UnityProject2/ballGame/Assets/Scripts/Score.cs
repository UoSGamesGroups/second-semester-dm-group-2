﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	[SerializeField] TextMesh _text;
	int score;

	void Update()
	{
		_text.text = score.ToString("N0");
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "ball")
		{
			score ++;
			col.gameObject.transform.position = new Vector3(0f,2.68f, 0f);
			col.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
			StartCoroutine(BallInactive(col.gameObject));
		}
	}


	IEnumerator BallInactive(GameObject obj)
	{
		obj.GetComponent<Rigidbody>().isKinematic = true;
		yield return new WaitForSeconds(1);
		obj.GetComponent<Rigidbody>().isKinematic = false;
	}
}
