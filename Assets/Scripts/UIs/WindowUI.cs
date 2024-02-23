using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WindowUI : BaseUI, IDragHandler
{
    // UI 드래그 하는 기능
    public void OnDrag(PointerEventData eventData) // 얼만큼 드래그 했는지 eventData에서 알 수 있음
    {
        transform.Translate(eventData.delta);
        // transform.position += (Vector3)eventData.delta;
    }
}
