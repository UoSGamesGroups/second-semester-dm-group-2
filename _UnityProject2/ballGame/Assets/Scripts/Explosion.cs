using UnityEngine;

public class Explosion : MonoBehaviour {

	[SerializeField] float power;
	GameObject[] boxes;


	void Awake()
	{
		boxes = GameObject.FindGameObjectsWithTag("box");
	}

	void OnTriggerEnter(Collider other)
	{
		foreach(GameObject a in boxes)
		{
			if(other.gameObject == a)
			{
				a.GetComponent<Rigidbody>().AddExplosionForce(power * Time.fixedDeltaTime,transform.position, 20f, 1, ForceMode.Impulse );
			}
		}

		Destroy(gameObject);
	}	



}
