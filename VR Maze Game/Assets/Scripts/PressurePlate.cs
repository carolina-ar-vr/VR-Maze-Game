using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressurePlate : MonoBehaviour
{
    // Public variables
    [SerializeField] UnityEvent PressedByPlayer;
	[SerializeField] UnityEvent PressedByObject;
	[SerializeField] UnityEvent Pressed;

	// On collision
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			PressedByPlayer.Invoke();
		} else
		{
			PressedByObject.Invoke();
		}
		Pressed.Invoke();
	}
}
