using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EventClick : MonoBehaviour, IPointerClickHandler
{
    private MaterialApplier materialApplier;
    
    private bool isOtherMaterialApplied = false;

    private void Awake()
    {
        materialApplier = GetComponent<MaterialApplier>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (isOtherMaterialApplied)
        {
            materialApplier.ApplyOriginal();
        }
        else
        {
            materialApplier.ApplyOther();
        }

        isOtherMaterialApplied = !isOtherMaterialApplied;
    }
}
