using UnityEngine;

public class SpawnUnits : MonoBehaviour
{
	[SerializeField] private GameObject unitTrooper;

	private void SpawnUnitByNumber(int _unitNumber)
	{
		if(_unitNumber == 0)
		{
			Instantiate(unitTrooper, gameObject.transform.position, Quaternion.identity, null);
		}
	}

	private void OnEnable()
	{
		HUDManager.SpawnUnitEvent += SpawnUnitByNumber;
	}

	private void OnDisable()
	{
		HUDManager.SpawnUnitEvent -= SpawnUnitByNumber;
	}
}