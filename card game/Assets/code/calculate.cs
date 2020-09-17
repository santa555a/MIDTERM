using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calculate : MonoBehaviour
{
    
    public int life = 20;
    public int lifeOp = 20;
    [SerializeField]
    Text lifeText;
    [SerializeField]
    Text lifeTextOp;
    public int result;
    public static calculate instant;
    void Start()
    {
        instant = this;
    }

    void Update()
    {
        lifeText.text = ""+life;
        lifeTextOp.text = "" + lifeOp;
        if (randomattack.instant.attackbool)
        {
            if (Dropzone.instants.damage >= randomattack.instant.numberattack)
            {
                result = Dropzone.instants.damage - randomattack.instant.numberattack;
                lifeOp -= result;
            }
            if (Dropzone.instants.damage <= randomattack.instant.numberattack)
            {
                result = randomattack.instant.numberattack - Dropzone.instants.damage;
                life -= result;
            }
            randomattack.instant.numberattack = Random.Range(3,5);
            Dropzone.instants.damage = 1;
            carddraw.instant.manacost = 5;
        }
        if (life >= 20)
            life = 20;
    }
}
