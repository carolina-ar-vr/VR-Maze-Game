using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.Events;

public class LeverInteractable : MonoBehaviour
{
    // Public variables
    public float angleThreshold = 20.0f;
    public delegate void LeverSwitched(bool isActive);
    public LeverSwitched leverSwitched;
    [HideInInspector] public bool leverActive = false;

    // Private variables
    private ConfigurableJoint joint;
    private float currentAngle = 0;

    // Start is called before the first frame update
    void Start()
    {
        joint = GetComponent<ConfigurableJoint>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UpdateState();
    }

    // Updating lever state
    void UpdateState()
    {
		currentAngle = gameObject.transform.localRotation.x * Mathf.Rad2Deg;
		if (currentAngle >= angleThreshold && leverActive == false)
		{
            leverActive = true;
            leverSwitched(leverActive);
		} else if (currentAngle <= -angleThreshold && leverActive == true)
        {
            leverActive = false;
            leverSwitched(leverActive);
		}
	}
}
