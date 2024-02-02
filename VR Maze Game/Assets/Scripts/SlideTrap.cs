using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideTrap : SlideDoor
{
	// Public variables
	public float resetTime = 3.0f;

	public override void OpenDoor()
	{
		base.OpenDoor();
		StartCoroutine(DelayedClosing());
	}

	// Delayed closing
	private IEnumerator DelayedClosing()
	{
		yield return new WaitForSeconds(resetTime + transitionTime);
		base.CloseDoor();
	}
}
