using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestUI : BaseUI
{
	protected override void Awake()
	{
		base.Awake(); // ���ε� ���� ���࿡ �ʿ�

		// Debug.Log("TestUI");
		/*texts["Title"].text = "Title";
		buttons["NextButton"].interactable = false;
		buttons["NextButton"].onClick.AddListener(Jump);*/

		// ��� ���
		// UI �߿��� �̸��� : "Name"�� ���ӿ�����Ʈ���� ������Ʈ Button�� ���� ���� �ʹ�.
		// GetUi<Button>("Name");

		GetUI<TMP_Text>("Title").text = "Title";
		GetUI<Button>("NextButton").interactable = false;
		GetUI<Image>("PlayerImage").color = Color.red;
	}
}
