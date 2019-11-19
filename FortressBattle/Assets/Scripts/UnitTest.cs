using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitTest : MonoBehaviour
{
	[SerializeField] private int movementSpeed = 1;
	[SerializeField] private int overlapRadius = 2;
	public LayerMask mask;

	private void Update()
	{
		Collider[] hitColliders = Physics.OverlapSphere(gameObject.transform.position, overlapRadius, mask);
		int i = 0;
		if(i < hitColliders.Length)
		{
			movementSpeed = 0;
			Debug.Log("Collider name: " + hitColliders[i].name);
			i++;
		}
		else
		{
			movementSpeed = 1;
			float _movementStep = movementSpeed * Time.deltaTime;
			transform.position = new Vector3(transform.position.x - _movementStep, transform.position.y, transform.position.z);
		}
		
	}

	private void OnDrawGizmos()
	{
		Gizmos.DrawWireSphere(gameObject.transform.position, overlapRadius);
		Gizmos.color = Color.red;
	}
}