using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Draggable : MonoBehaviour ,IBeginDragHandler , IDragHandler , IEndDragHandler 
{
    [SerializeField]
    public int increasedamage;
    public bool draww=false;
    
    public static Draggable instant;

    void Start()
    {
        instant = this;
        
    }

    public Transform parentToReturnTo = null;
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (carddraw.instant.manacost >= 1)
        {
            Debug.Log("OnBeginDrag");
            parentToReturnTo = this.transform.parent;
            this.transform.SetParent(this.transform.parent.parent);
            Audio.instant.selectcardd();
            GetComponent<CanvasGroup>().blocksRaycasts = false;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (carddraw.instant.manacost >= 1)
        {
            Debug.Log("OnDrag");
            this.transform.position = eventData.position;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (carddraw.instant.manacost >= 1)
        {
            Audio.instant.playcardd();
            Debug.Log("OnEndDrag");
            this.transform.SetParent(parentToReturnTo);
            GetComponent<CanvasGroup>().blocksRaycasts = true;
            if (gameObject.tag == "Red")
            {
                carddraw.instant.cardinhand -= 1;
                Dropzone.instants.damage++;
                carddraw.instant.manacost -= 1;
                Animationtable.instant.effect = 1;
            }
            if (gameObject.tag == "Blue")
            {
                randomattack.instant.numberattack--;
                carddraw.instant.cardinhand -= 1;
                carddraw.instant.manacost -= 1;
                Animationtable.instant.effect = 2;
            }
            if (gameObject.tag == "Yellow")
            {
                carddraw.instant.canDrawCard = true;
                carddraw.instant.cardinhand -= 1;
                carddraw.instant.manacost -= 1;
                Animationtable.instant.effect = 4;
            }
            if (gameObject.tag == "Green")
            {
                carddraw.instant.cardinhand -= 1;
                calculate.instant.life += 1;
                carddraw.instant.manacost -= 1;
                Animationtable.instant.effect = 3;
            }
        }
    }
    
}
