using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TowerPlace : MonoBehaviour
	, IPointerClickHandler
	, IPointerEnterHandler
	, IPointerExitHandler
	, IPointerUpHandler
	, IPointerDownHandler
	, IPointerMoveHandler
{

	// public UnityEvent OnPointerEntered;
	// public UnityEvent OnPointerExited;
	[SerializeField] Renderer render;
	[SerializeField] Color normalColor;
	[SerializeField] Color highlightColor;

	public void OnPointerClick(PointerEventData eventData)
	{
		Debug.Log("Click");
	}
	public void OnPointerEnter(PointerEventData eventData)
	{
		Debug.Log("Enter");
		// OnPointerEntered?.Invoke();
		render.material.color = highlightColor;
	}
	public void OnPointerExit(PointerEventData eventData)
	{
		Debug.Log("Exit");
		// OnPointerExited?.Invoke();
		render.material.color = normalColor;
	}
	public void OnPointerUp(PointerEventData eventData)
	{
		Debug.Log("Up");
	}
	public void OnPointerDown(PointerEventData eventData)
	{
		Debug.Log("Down");
	}
	public void OnPointerMove(PointerEventData eventData)
	{
		// Debug.Log("Move");
	}
}
