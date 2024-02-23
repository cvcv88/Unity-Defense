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

		foreach(RectTransform child in children) // ��� �ڽĵ� ��ȸ�ϸ鼭 �̸� �������ѳ���
		{
			string name = child.gameObject.name; // ���ӿ�����Ʈ�� �̸��� �������� 

			if (transforms.ContainsKey(name))
				continue;

			transforms.Add(name, child);

			// ��ư������Ʈ ã�ƺ���
			// ���� ��ư������Ʈ�� null�� �ƴϸ�
			// ��ư�� ��ųʸ��� �߰��Ѵ�
			Button button = child.GetComponent<Button>();
			if(button != null)
			{
				buttons.Add(name, button);
			}

			// null�� �ƴϸ� �ؽ�Ʈ�� ��ųʸ��� �߰��Ѵ� : ���ε�
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
