using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;


public class FontColorChanger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] 
    public TextMeshProUGUI text;
    public void OnPointerEnter(PointerEventData eventData)
    {
        text.GetComponent<TextMeshProUGUI>().color = Color.black;
    }
 
    public void OnPointerExit(PointerEventData eventData)
    {
        text.GetComponent<TextMeshProUGUI>().color = Color.white;
    }
}
