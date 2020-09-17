using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carddraw : MonoBehaviour
{
    public GameObject hand;
    public GameObject carddraww;
    public GameObject redcard;
    public GameObject bluecard;
    public GameObject yellowcard;
    public GameObject greencard;
    public int draw;
    public int cardinhand=0;
    public int manacost = 5;
    [SerializeField]
    Text manatext;
    public bool canDrawCard=false;
    public static carddraw instant;
    
    void Start()
    {
        instant = this;
        
        for (int a = 0; a < 4; a++)
        {
            
            draw = Random.Range(1, 11);
            if (draw >= 7)
            {
                Debug.Log("CreateBystart1");
                GameObject germSpawned = Instantiate(redcard) as GameObject;
                germSpawned.transform.SetParent(carddraww.transform);
                cardinhand += 1;
            }
            if (draw >= 4 && draw <= 6)
            {
                Debug.Log("CreateBystart2");
                GameObject germSpawned = Instantiate(bluecard) as GameObject;
                germSpawned.transform.SetParent(carddraww.transform);
                cardinhand += 1;
            }
            if (draw == 1)
            {
                Debug.Log("CreateBystart3");
                GameObject germSpawned = Instantiate(yellowcard) as GameObject;
                germSpawned.transform.SetParent(carddraww.transform);
                cardinhand += 1;
            }
            if (draw >= 2 && draw <= 3)
            {
                Debug.Log("CreateBystart4");
                GameObject germSpawned = Instantiate(greencard) as GameObject;
                germSpawned.transform.SetParent(carddraww.transform);
                cardinhand += 1;
            }
            
        }
        GetComponent<HorizontalLayoutGroup>().spacing = 245;
    }

    void Update()
    {
        manatext.text = "" + manacost;
        //draw
        if (randomattack.instant.roundstart == true)
        {
            for (int i = 0; i < 4; i++)
            {

                Audio.instant.drawcardd();
                draw = Random.Range(1, 11);
                if (draw >= 7)
                {
                    GameObject germSpawned = Instantiate(redcard) as GameObject;
                    germSpawned.transform.SetParent(carddraww.transform);

                }
                if (draw >= 4 && draw <= 6)
                {
                    GameObject germSpawned = Instantiate(bluecard) as GameObject;
                    germSpawned.transform.SetParent(carddraww.transform);

                }
                if (draw == 1)
                {
                    GameObject germSpawned = Instantiate(yellowcard) as GameObject;
                    germSpawned.transform.SetParent(carddraww.transform);

                }
                if (draw >= 2 && draw <= 3)
                {
                    GameObject germSpawned = Instantiate(greencard) as GameObject;
                    germSpawned.transform.SetParent(carddraww.transform);

                }

            }
        
        randomattack.instant.roundstart = false;
        cardinhand += 4 ;
    }
            
        
        //play yellow
        if (canDrawCard==true)
        {
            for (int i = 0; i < 2; i++)
            {
                Audio.instant.drawcardd();
                draw = Random.Range(1, 11);
                if (draw >= 7)
                {
                    GameObject germSpawned = Instantiate(redcard) as GameObject;
                    germSpawned.transform.SetParent(carddraww.transform);
                }
                if (draw >= 4 && draw <= 6)
                {
                    GameObject germSpawned = Instantiate(bluecard) as GameObject;
                    germSpawned.transform.SetParent(carddraww.transform);
                }
                if (draw == 1)
                {
                    GameObject germSpawned = Instantiate(yellowcard) as GameObject;
                    germSpawned.transform.SetParent(carddraww.transform);
                }
                if (draw >= 2 && draw <= 3)
                {
                    GameObject germSpawned = Instantiate(greencard) as GameObject;
                    germSpawned.transform.SetParent(carddraww.transform);
                }
                
            }
            canDrawCard = false;
            cardinhand += 2;
        }
        if (cardinhand <= 4)
        {
            GetComponent<HorizontalLayoutGroup>().spacing = 180;
        }
        if (cardinhand == 5)
        {
            GetComponent<HorizontalLayoutGroup>().spacing = 130;
        }
        if (cardinhand == 6)
        {
            GetComponent<HorizontalLayoutGroup>().spacing = 80;
        }
        if (cardinhand == 7)
        {
            GetComponent<HorizontalLayoutGroup>().spacing = 80;
        }
        if (cardinhand >= 7)
        {
            GetComponent<HorizontalLayoutGroup>().spacing = 30;
        }

    }
   
}
