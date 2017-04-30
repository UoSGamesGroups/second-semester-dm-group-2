using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDialogues : MonoBehaviour {

	
	[SerializeField] GameObject dialoguePNG;
	[SerializeField] float x_min;
	[SerializeField] float x_max;

	float time;


	IEnumerator Start()
	{
		while(true)
		{
			time = Random.Range(1,6);
			yield return new WaitForSeconds(time);
			dialoguePNG.gameObject.SetActive(true);
			dialoguePNG.transform.position = new Vector2(Random.Range(x_min, x_max), Random.Range(-5.5f, -3.5f));
			yield return new WaitForSeconds(2);
			dialoguePNG.gameObject.SetActive(false);
		}
	}



}
