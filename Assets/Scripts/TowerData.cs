using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "TowerData", menuName = "Data/Tower")]
// create�� ���ؼ� ����� Asset �����̸�, �޴��̸�
public class TowerData : ScriptableObject // ������Ʈ�� �ƴϰ� Ÿ�Ϸ� �����Ǿ�����
{
	/*public new string name;
	[TextArea(3, 5)] public string description;
	public Tower prefab;
	public Sprite icon;
	public int damage;
	[Range(0, 10)] public int range;
	public int CoolTime;
	public float buildTime;
	public float buildCost;
	public float sellCost;

	public TowerData nextLevelTowerData;*/

	// ����1~3 ��� ���� ��������
	public Tower prefab;
	public TowerInfo[] towers;

	[Serializable]
	public struct TowerInfo
	{
		public string name;

		public Mesh cons;
		public Mesh build;

		public int damage;
		public float range;

		public float buildTime;
		public int buildCost;
		public int sellCost;
	}
}
