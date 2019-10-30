﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject PlayerHealthbar;
    public GameObject EnemyHealthbar;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            PlayerHealthbar.GetComponent<Healthbar>().DecreaseHealth();

        }

        if (Input.GetButtonDown("Fire2"))
        {
            EnemyHealthbar.GetComponent<Healthbar>().DecreaseHealth();
        }

        if (Input.GetButtonDown("Fire3"))
        {
            GetComponent<AttackState>().nextArrow();
        }


    }
}
