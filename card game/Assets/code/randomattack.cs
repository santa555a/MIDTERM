using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomattack : MonoBehaviour
{
    public bool attackbool = false;
    public bool roundstart = false;
    public int numberattack = 1;
    public bool candraw = false;
    int result;
    [SerializeField]
    Text attackOp;

    public static randomattack instant;
    void Start()
    {
        instant = this;

    }

    // Update is called once per frame
    void Update()
    {

        attackOp.text = "" + numberattack;
        attackbool = false;

    }
    public void randomstartturn()
    {
        candraw = true;
        attackbool = true;
        roundstart = true;
        
        
    }
    
        
    
}
