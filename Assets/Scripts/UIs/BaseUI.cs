using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BaseUI : MonoBehaviour
{
	// public RectTransform[] children;

	/*protected Dictionary<string, RectTransform> transforms;
	protected Dictionary<string, Button> buttons;
	protected Dictionary<string, TMP_Text> texts;*/
	// TODO : add ui component

	protected Dictionary<string, Component> components;

	protected virtual void Awake()
	{
		// Debug.Log("Binding");
		Bind();
	}

	private void Bind()
	{
		/*transforms = new Dictionary<string, RectTransform>();
		buttons = new Dictionary<string, Button>();
		texts = new Dictionary<string, TMP_Text>();	

		RectTransform[] children = GetComponentsInChildren<RectTransform>();

		foreach(RectTransform child in children) // 모든 자식들 순회하면서 미리 참조시켜놓자
		{
			string name = child.gameObject.name; // 게임오브젝트의 이름을 기준으로 

			if (transforms.ContainsKey(name))
				continue;

			transforms.Add(name, child);

			// 버튼컴포넌트 찾아보고
			// 만약 버튼컴포넌트가 null이 아니면
			// 버튼을 딕셔너리에 추가한다
			Button button = child.GetComponent<Button>();
			if(button != null)
			{
				buttons.Add(name, button);
			}

			// null이 아니면 텍스트를 딕셔너리에 추가한다 : 바인딩
			TMP_Text text = child.GetComponent<TMP_Text>();
			if(text != null)
			{
				texts.Add(name, text);
			}
		}*/

		components = new Dictionary<string, Component>();
		Component[] children = GetComponentsInChildren<Component>();
        foreach (Component child in children)
		{
			string name = $"{child.gameObject.name}_{child.GetType().Name}";
			components.Add(name, child);
		}
    }
	public T GetUI<T>(string name) where T : Component
	{
		return components[$"{name}_{typeof(T).Name}"] as T;
	}
}
