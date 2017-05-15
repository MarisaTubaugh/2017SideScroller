using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
	public Transform newPos;

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
			other.position = newPos.position; (-6.1788, 1.035913, 0);
	}
}
