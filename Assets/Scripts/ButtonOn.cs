using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonOn : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private Button _Button;

    public void OnPointerDown(PointerEventData eventData)
    {
        ButtonActive();
    }

    private void ButtonActive()
    {
        _Button.interactable = true;
    }
}
