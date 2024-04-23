using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Events;

public class LeverInteractable : MonoBehaviour
{
    // Public variables
    public float angleThreshold = 20.0f;
    [SerializeField] public UnityEvent leverOn;
    [SerializeField] public UnityEvent leverOff;
    [HideInInspector] public bool leverActive = false;

    // Private variables
    private ConfigurableJoint joint;
    private float currentAngle = 0;
    private bool firstSwitch = true;

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
		if (currentAngle >= angleThreshold && (leverActive == false || firstSwitch == true))
		{
            leverActive = true;
            firstSwitch = false;
			leverOn.Invoke();
		} else if (currentAngle <= -angleThreshold && (leverActive == true || firstSwitch == true))
        {
            leverActive = false;
            firstSwitch = false;
			leverOff.Invoke();
		}
	}
}
