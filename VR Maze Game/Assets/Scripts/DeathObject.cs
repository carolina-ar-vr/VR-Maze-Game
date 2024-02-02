using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathObject : VibrationManager
{
	// Public variables
	public Transform respawn;

	// Private variables
	protected Transform playerTransform;

	// Start
	protected override void Start()
	{
		base.Start();
		playerTransform = GameObject.FindGameObjectWithTag("XROrigin").transform;
		intensity = 1.0f;
		duration = 1.0f;
	}

	// Killing
	public void KillPlayer()
	{
		playerTransform.position = respawn.position;
		TriggerVibration();
	}
}
