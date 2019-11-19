using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fortress : MonoBehaviour
{

	[SerializeField] private int buildingHealth;
	[SerializeField] private int buildingMaxHealth;

    // Start is called before the first frame update
    private void Start()
    {
		buildingHealth = buildingMaxHealth;
    }
}