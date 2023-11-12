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

	// On update
	//private void Update()
	//{
	//	RaycastHit hit;
	//	if (Physics.BoxCast(plate.transform.position, plate.transform.localScale / 2, new Vector3(0, 1, 0), out hit, plate.transform.rotation, maxDistance))
	//	{
	//		if (hit.transform.gameObject.tag == "Player")
	//		{
	//			PressedByPlayer.Invoke();
	//		} else
	//		{
	//			PressedByObject.Invoke();
	//		}
	//		Pressed.Invoke();
	//	}
	//}
}
