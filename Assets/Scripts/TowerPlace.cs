using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TowerPlace : MonoBehaviour
	, IPointerClickHandler
	, IPointerEnterHandler
	, IPointerExitHandler
	/*, IPointerUpHandler
	, IPointerDownHandler
	, IPointerMoveHandler*/
{

	// public UnityEvent OnPointerEntered;
	// public UnityEvent OnPointerExited;
	[SerializeField] Renderer render;
	[SerializeField] Color normalColor;
	[SerializeField] Color highlightColor;

	[SerializeField] InGameUI buildUI;

	[Header("Tower")]
	[SerializeField] TowerData archorTower;
	[SerializeField] TowerData cannonTower;

	public void OnPointerClick(PointerEventData eventData)
	{
		// Debug.Log("Click");
		// BuildUI ui = Manager.UI.ShowInGameUI(buildUI);
		// ui.SetTarget(transform);
		// ui.SetTowerPlace(this);

	}
	public void OnPointerEnter(PointerEventData eventData)
	{
		// Debug.Log("Enter");
		// OnPointerEntered?.Invoke();
		render.material.color = highlightColor;
	}
	public void OnPointerExit(PointerEventData eventData)
	{
		// Debug.Log("Exit");
		// OnPointerExited?.Invoke();
		render.material.color = normalColor;
	}
	/*public void OnPointerUp(PointerEventData eventData)
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
	}*/

	public void BuildTower(string name)
	{
		/*if(name == "Archor")
		{
			Debug.Log($"{archorTower.buildCost}");
			Debug.Log($"{archorTower.buildTime}");

			Destroy(gameObject);
			Instantiate(archorTower, transform.position, transform.rotation);
		}*/
		if(name == "Archor")
		{
			gameObject.SetActive(false);
			Tower tower = Instantiate(archorTower.prefab, transform.position, transform.rotation);
			tower.SetTowerPlace(this);
		}
		if (name == "Cannon")
		{
			gameObject.SetActive(false);
			Tower tower = Instantiate(cannonTower.prefab, transform.position, transform.rotation);
			tower.SetTowerPlace(this);
		}
	}
}
