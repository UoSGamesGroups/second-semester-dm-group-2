using UnityEngine;

public class Controller : MonoBehaviour {

	[SerializeField] GameObject explosion;

	RaycastHit _raycast;
	Ray ray;
	int mask;

	public int counter = 3;
	[SerializeField] GameObject[] lives; 

	void Awake()
	{
		mask = LayerMask.GetMask("floor");
	}
	
	void Update()
	{
		Lives();
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		if(Input.GetKeyDown(KeyCode.Mouse0) )
		{
			RaycastHit2D _rc = Physics2D.Raycast(new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,Camera.main.ScreenToWorldPoint(Input.mousePosition).y), Vector2.zero, mask);
	
			Instantiate(explosion, _rc.point, transform.rotation);
			counter--;
		}
	}

	void Lives()
	{
			if(counter == 3)
			{
				lives[0].gameObject.SetActive(true);
				lives[1].gameObject.SetActive(true);
				lives[2].gameObject.SetActive(true);
			}

			if(counter == 2)
			{
				lives[0].gameObject.SetActive(true);
				lives[1].gameObject.SetActive(true);
				lives[2].gameObject.SetActive(false);
			}
			if(counter == 1)
			{
				lives[0].gameObject.SetActive(true);
				lives[1].gameObject.SetActive(false);
				lives[2].gameObject.SetActive(false);
			}
				if(counter == 0)
			{
				lives[0].gameObject.SetActive(false);
				lives[1].gameObject.SetActive(false);
				lives[2].gameObject.SetActive(false);
			}

		}
}


	


