using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIManager : MonoBehaviour
{
	[SerializeField] EventSystem eventSystemPrefab;


	private Stack<PopUpUI> popUpStack = new Stack<PopUpUI>();

	private void Awake()
	{
		EnsureEventSystem();
	}

	public void EnsureEventSystem()
	{
		EventSystem eventSystem = FindObjectOfType<EventSystem>();
		if (eventSystem == null)
		{
			Instantiate(eventSystemPrefab);
		}
	}

	// 일반화 이유
	// 일시정지 팝업, 경고 팝업, 아이디 생성 팝업 등 여러가지 팝업 가능
	public T ShowPopUpUI<T>(T popUpUI) where T : PopUpUI
	{
		if(popUpStack.Count > 0)
		{
			PopUpUI prevUI = popUpStack.Peek(); // 스택 맨위에 있는 게, 열려있는 팝업
			prevUI.gameObject.SetActive(false);
		}
		T instance = Instantiate(popUpUI);
		popUpStack.Push(instance);
		Time.timeScale = 0;

		return instance;
	}
	public void ClosePopUpUI()
	{
		PopUpUI curUI = popUpStack.Pop(); // 최상단의 팝업 꺼내기
		Destroy(curUI.gameObject);

		if(popUpStack.Count > 0)
		{
			PopUpUI prevUI = popUpStack.Peek();
			prevUI.gameObject.SetActive(true);
		}
		else
		{
			Time.timeScale = 1f;
		}
	}
}
