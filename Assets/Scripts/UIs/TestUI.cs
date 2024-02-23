using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestUI : BaseUI
{
	protected override void Awake()
	{
		base.Awake(); // 바인딩 과정 진행에 필요

		// Debug.Log("TestUI");
		/*texts["Title"].text = "Title";
		buttons["NextButton"].interactable = false;
		buttons["NextButton"].onClick.AddListener(Jump);*/

		// 사용 방법
		// UI 중에서 이름이 : "Name"인 게임오브젝트에서 컴포넌트 Button을 갖다 쓰고 싶다.
		// GetUi<Button>("Name");

		GetUI<TMP_Text>("Title").text = "Title";
		GetUI<Button>("NextButton").interactable = false;
		GetUI<Image>("PlayerImage").color = Color.red;
	}
}
