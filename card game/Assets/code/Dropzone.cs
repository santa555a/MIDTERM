using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class Dropzone : MonoBehaviour, IDropHandler,IPointerEnterHandler,IPointerExitHandler
{
    public int damage=1;
    [SerializeField]
    Text damagetext;
    public static Dropzone instants;
    void Start()
    {
        instants = this;
    }
        void Update() 
    {
        damagetext.text = ""+damage;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop to" + gameObject.name);
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            d.parentToReturnTo = this.transform;
            
                
            
        }
    }
}
