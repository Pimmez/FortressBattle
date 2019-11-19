using UnityEngine;
using System;

public class HUDManager : MonoBehaviour
{
	public static Action<int> SpawnUnitEvent;

 	public void SpawnUnit(int _unitNumber)
	{
		if(SpawnUnitEvent != null)
		{
			SpawnUnitEvent(_unitNumber);
		}
	}
}