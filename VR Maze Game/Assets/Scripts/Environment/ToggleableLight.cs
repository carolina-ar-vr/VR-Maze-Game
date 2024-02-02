using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class ToggleableLight : MonoBehaviour
{
    // Private variables
    private Light lightObj;

	// Start
	private void Start()
	{
		lightObj = GetComponent<Light>();;
	}

	public void SetLightActive(bool toSet)
	{
		lightObj.enabled = toSet;
	}
}
