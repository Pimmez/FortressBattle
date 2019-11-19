using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
	[SerializeField] private int movementSpeed;

	private void Update()
	{
		float _movementStep = movementSpeed * Time.deltaTime;
		transform.position = new Vector3(transform.position.x + _movementStep, transform.position.y, transform.position.z);
	}
}