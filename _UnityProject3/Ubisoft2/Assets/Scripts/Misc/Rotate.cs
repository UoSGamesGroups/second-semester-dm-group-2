using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	[SerializeField] float rs = 20f;
	
	void Update()
	{
		transform.Rotate(Vector3.forward * Time.deltaTime * rs);
	}



}
