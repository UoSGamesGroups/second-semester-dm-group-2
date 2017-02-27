using UnityEngine;

public class Controller : MonoBehaviour {

	[SerializeField] GameObject explosion;

	RaycastHit _raycast;
	Ray ray;
	int mask;

	void Awake()
	{
		mask = LayerMask.GetMask("floor");
	}
	
	void Update()
	{
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		if(Input.GetKeyDown(KeyCode.Mouse0))
		{
			RaycastHit2D _rc = Physics2D.Raycast(new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,Camera.main.ScreenToWorldPoint(Input.mousePosition).y), Vector2.zero, mask);
			Instantiate(explosion, _rc.point, transform.rotation);
		}
	}


	


}
