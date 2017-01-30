using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fireFireBall : MonoBehaviour {

	

    [SerializeField] GameObject fireBall;
    [SerializeField] KeyCode shoot;

    [SerializeField] Text ammoVizuali;
    int ammo = 2;
    float currentReloadTime;
    [SerializeField]float endReloadTime;


    void Update()
    {
        Reload();
        if (Input.GetKeyDown(shoot) && ammo>0)
        {
            Instantiate(fireBall, transform.position, this.transform.rotation);
            ammo--;
        }
    }

    void Reload()
    {
        ammoVizuali.text = ammo + " | " + currentReloadTime.ToString("N1");

        if (ammo < 2)
        {
            currentReloadTime += Time.deltaTime;
            if (currentReloadTime >= endReloadTime)
            {
                ammo++;
                currentReloadTime = 0;
            }
        }
    }



}
