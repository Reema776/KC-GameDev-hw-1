using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW1 : MonoBehaviour
{

    string hero = "hulk";
    int health = 100;
    int health2 = 100;
    string result = " is less than ";
    string result1 = " is more than ";
    int herohealth = 100;
    string rr = " Damaged health : ";
    string rrr = " Boost health : ";



    // Start is called before the first frame update
    void Start()
    {
        print(health);
        damaged();
        boost();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void damaged()
    {
        health = health - 20;
        print(rr + health);
        print(health + result + health2);
    }

    void boost()
    {
        health = health + 10;
        print(rrr + health);
        print(health + result1 + health2);
    }

}
