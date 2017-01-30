using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballBehaviour : MonoBehaviour {


    [SerializeField] float power;
    [SerializeField] float life = 2;

    Rigidbody2D _rigid;
    bool isIgnoringPlayer;
    


    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    IEnumerator IgnorePLayer()
    {
        yield return new WaitForSeconds(0.1f);
        gameObject.layer = 0;
    }

    void Start()
    {
        
        _rigid.AddForce(transform.right * power * Time.fixedDeltaTime*1000f);
        StartCoroutine(IgnorePLayer());
    }


    private void Update()
    {
        if (life <= 0)
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
            life--;
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<playerStats>().Hp--;
            Destroy(this.gameObject);
        }
    }
}
