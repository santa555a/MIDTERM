using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationtable : MonoBehaviour
{
    public int time=0;
    public Animator tableani;
    public int effect=0;
    public static Animationtable instant;
    void Start()
    {
        instant = this;
        tableani = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (effect == 1)
        {
            tableani.SetBool("Red", true);
            time++;
        }
        if (time >= 10)
        {
            effect = 0;
            tableani.SetBool("Red", false);
            tableani.SetBool("Blue", false);
            tableani.SetBool("Green", false);
            tableani.SetBool("Yellow", false);
            time = 0;


        }

        if (effect == 2)
        {
            tableani.SetBool("Blue", true);
            time++;
            tableani.SetBool("attack", true);
        }
        if (effect == 3)
        {
            tableani.SetBool("Green", true);
            time++;
        }
        if (effect == 4)
        {
            tableani.SetBool("Yellow", true);
            time++;
        }

        


    }
}
