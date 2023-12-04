using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VibrationManager : MonoBehaviour
{
	// Public variables
	[Range (0.0f, 1.0f)]
	public float leftRightSpread = 0.5f;
	[Range(0.0f, 1.0f)]
	public float intensity = 0.5f;
	public float duration = 0.5f;

    // Private variables
    GameObject xrOrigin;
	XRBaseController leftController;
	XRBaseController rightController;

	// Start
	protected virtual void Start()
	{
        xrOrigin = GameObject.FindGameObjectWithTag("XROrigin");
		leftController = xrOrigin.transform.Find("Camera Offset/Left Controller").GetComponent<XRBaseController>();
		rightController = xrOrigin.transform.Find("Camera Offset/Right Controller").GetComponent<XRBaseController>();
	}

	// Triggering vibration
	public void TriggerVibration()
    {
        if (intensity > 0 && intensity <= 1)
        {
			rightController.SendHapticImpulse(intensity * (1 - leftRightSpread) * 2, duration);
			leftController.SendHapticImpulse(intensity * leftRightSpread * 2, duration);
        }
    }
}
