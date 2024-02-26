using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "TowerData", menuName = "Data/Tower")]
// create를 통해서 만드는 Asset 파일이름, 메뉴이름
public class TowerData : ScriptableObject // 컴포넌트는 아니고 타일로 구성되어있음
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

	// 레벨1~3 모두 같이 관리하자
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
