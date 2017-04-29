using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorBehaviour : MonoBehaviour {

	[SerializeField] float ms;
	Rigidbody2D rigid;
	GameObject target;
	int count = 0;
	[SerializeField]bool isActive;
	Timer timer;


	void Awake()
	{
		rigid = GetComponent<Rigidbody2D>();
		target = GameObject.FindGameObjectWithTag("Target");
		timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
	}

	IEnumerator Start()
	{
		yield return new WaitForSeconds(3f);
		isActive = false;
		timer.endTime  = 4;
		yield return new WaitForSeconds(4f);
		BuildingBehaviour.isLocked = true;
		isActive = true;
		ms *=15f;
	}

	void WOw()
	{
		Vector3 dir = target.transform.position - transform.position;
 		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
 		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
	}


	void Update()
	{
		WOw();
		Movement();
		DestroyOnMaxCount();
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "Building")
		{
			isActive = false;
			rigid.gravityScale = 1;
		}

		if(col.gameObject.tag == "Base_l")
		{
			BuildingBehaviour.isLocked = false;
			GameController.globalScoreLeft ++;
			Destroy(col.gameObject);
			Destroy(gameObject);
		}

		if(col.gameObject.tag == "Base_r")
		{
			BuildingBehaviour.isLocked = false;
			GameController.globalScoreRight ++;
			Destroy(col.gameObject);
			Destroy(gameObject);
		}

		if(col.gameObject.tag == "Floor")
		{
			isActive = false;
			rigid.gravityScale = 1;
			count ++;
			if(count == 1)
				rigid.AddForce(Vector2.up * 350);
		}
	}

	void Movement()
	{
		if(isActive)
		{
			rigid.MovePosition(transform.position + transform.right * ms * Time.deltaTime);
		}
	}

	void DestroyOnMaxCount()
	{
		if(count >= 2)
		{
			BuildingBehaviour.isLocked = false;
			Destroy(gameObject);
		}
	}
}
