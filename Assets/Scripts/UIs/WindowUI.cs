using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WindowUI : BaseUI, IDragHandler
{
    // UI �巡�� �ϴ� ���
    public void OnDrag(PointerEventData eventData) // ��ŭ �巡�� �ߴ��� eventData���� �� �� ����
    {
        transform.Translate(eventData.delta);
        // transform.position += (Vector3)eventData.delta;
    }
}
