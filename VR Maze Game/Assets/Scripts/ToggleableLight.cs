using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class ToggleableLight : MonoBehaviour
{
	// Public variables
	public LeverInteractable lever;

    // Private variables
    private Light lightObj;

	// Start
	private void Start()
	{
		lightObj = GetComponent<Light>();
		lever.leverSwitched += OnLeverToggle;
	}

	public void OnLeverToggle(bool isActive)
    {
		lightObj.enabled = isActive;
    }
}
