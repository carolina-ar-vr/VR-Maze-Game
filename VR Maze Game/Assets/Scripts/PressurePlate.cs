using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressurePlate : MonoBehaviour
{
    // Public variables
    [SerializeField] UnityEvent PressedByPlayer;
	[SerializeField] UnityEvent PressedByObject;

	// Private variables
	private GameObject door;

	// On start
	private void Start()
	{
		door = transform.Find("Door").gameObject;
	}

	// On update
	private void Update()
	{
		RaycastHit hit;
		if (Physics.BoxCast(door.transform.position, door.transform.localScale / 2, new Vector3(0, 1, 0), out hit, door.transform.rotation))
		{
			PressedByObject.Invoke();
		}
	}
}
