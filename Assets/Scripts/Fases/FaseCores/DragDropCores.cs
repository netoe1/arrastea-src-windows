using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEditor;

public class DragDropCores :
    MonoBehaviour,
    IPointerDownHandler,
    IBeginDragHandler,
    IDragHandler,
    IEndDragHandler
{ 

    /*Esta classe pertence aos gameobjects que ser�o arrastados!*/



    /*obj UI*/
    const float alpha = 0.5f;
    Vector3 posicaoInicial;

    /*Propriedades*/
    private RectTransform rt;
    private CanvasGroup cg;

    

    void Awake()
    {
        ConfiguraCursor.instance.ActiveCursor();
        rt = GetComponent<RectTransform>();
        posicaoInicial = rt.anchoredPosition;
        cg = GetComponent<CanvasGroup>();
        cg.blocksRaycasts = true;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        cg.alpha -= alpha;
        cg.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {

        rt.anchoredPosition += eventData.delta / CenaDinamicaCores.get_scaleFactor();
        ConfiguraCursor.instance.ActiveCursorDrag();
      
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        ConfiguraCursor.instance.ActiveCursor();
        cg.alpha += alpha;
        cg.blocksRaycasts = true;
        rt.anchoredPosition = posicaoInicial;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ConfiguraSom.tocarSomCores(this.gameObject.tag);
        ConfiguraCursor.instance.ActiveCursor();
    }
}
