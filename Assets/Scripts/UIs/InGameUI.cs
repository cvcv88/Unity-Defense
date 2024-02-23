using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameUI : BaseUI
{
    // �ΰ��� ����â UI
    public Transform followTarget;
	public Vector3 followOffset;

	private void LateUpdate()
	{
		if (followTarget == null)
			return;
		
		// transform.position = followTarget.position;
		transform.position = Camera.main.WorldToScreenPoint(followTarget.position) + followOffset;
		// ���ӿ�����Ʈ�� ��ġ�� ȭ�� ��ġ�� ��ȯ���ִ� �Լ�
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
