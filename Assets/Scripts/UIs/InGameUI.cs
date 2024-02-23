using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameUI : BaseUI
{
    // 인게임 정보창 UI
    public Transform followTarget;
	public Vector3 followOffset;

	private void LateUpdate()
	{
		if (followTarget == null)
			return;
		
		// transform.position = followTarget.position;
		transform.position = Camera.main.WorldToScreenPoint(followTarget.position) + followOffset;
		// 게임오브젝트의 위치를 화면 위치로 변환해주는 함수
	}

	public void SetTarget(Transform target)
	{
		followTarget = target;
	}

	public void SetOffset(Vector3 offset)
	{
		followOffset = offset;
	}
}
