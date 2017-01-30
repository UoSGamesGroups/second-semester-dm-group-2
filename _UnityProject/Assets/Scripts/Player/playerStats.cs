using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerStats : MonoBehaviour {


    [SerializeField]Text hpText;
    [SerializeField]float hp = 3;
    public float Hp
    {
        get { return hp; }
        set { hp = value; }
    }


    void Update()
    {
        hpText.text = "Hp: " + hp.ToString();

        if (hp <= 0)
            Destroy(gameObject); 
    }
    
}
