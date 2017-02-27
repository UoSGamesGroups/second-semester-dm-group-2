using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovementBehaviour : MonoBehaviour {


    [SerializeField] private float ms;  //movement speed
    [SerializeField] private float jp;  //jump power
    [SerializeField] private float gravityPower;  //jump power

    [Header("Keys")]
    [SerializeField] KeyCode _left;
    [SerializeField] KeyCode _right;
    [SerializeField] KeyCode _jump;


    private int numberOfJumps=2;


    private Rigidbody2D _rigid;


    void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Jump();
        CustomGravity();
        if (Input.GetKeyDown(KeyCode.F1))
            SceneManager.LoadScene("game1");

    }

    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(_left))
        {
            Vector3 direction = new Vector3(-1, 0f, 0f) * Time.fixedDeltaTime * ms * 1000f;
            _rigid.AddForce(direction);
            Rotate(-1);
        }
        else if(Input.GetKey(_right))
        {
            Vector3 direction = new Vector3(1, 0f, 0f) * Time.fixedDeltaTime * ms * 1000f;
            _rigid.AddForce(direction);
            Rotate(1);
        }
        
    }

    void Rotate(float direction)
    {
        if (direction > 0)
            transform.rotation = Quaternion.Euler(0f,0f,0f);
        else  if(direction<0)
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);


    }


    void Jump()
    {
        if (Input.GetKeyDown(_jump) & numberOfJumps >0)
        {
            _rigid.AddForce(Vector3.up * jp * 10f * Time.fixedDeltaTime, ForceMode2D.Impulse);
            numberOfJumps--;
        }
    }

    void CustomGravity()
    {
            _rigid.AddForce(Vector3.up * -gravityPower*  Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ground")
        {
            numberOfJumps = 2;
        }
    }

   
}
