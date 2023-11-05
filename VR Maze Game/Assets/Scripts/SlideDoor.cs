using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;

public class SlideDoor : MonoBehaviour
{
    // Public variables
    public float transitionTime = 1.0f;

    // Private variables
    private Transform openPosition;
    private Transform closePosition;
    private GameObject doorObject;

    private float currentTime = 0.0f;
    private float alpha = 0.0f;
    private bool isPlaying = false;
    private bool direction = true;
    private bool isOpen = false;

    // Easing function
    private float CosineEasing(float linearAlpha)
    {
        return -Mathf.Cos((2f * Mathf.PI * linearAlpha) / 2f) / 2f + 0.5f;
    }
    private float EasingOut(float linearAlpha)
    {
        return Mathf.Pow(linearAlpha, 2);
    }
    private float EasingIn(float linearAlpha)
    {
        return Mathf.Pow(linearAlpha, 1/2);
	}

	// Starting to open or close
	public virtual void OpenDoor()
	{
        if (isPlaying == false && isOpen == false)
		{
			direction = true;
			currentTime = 0.0f;
			isPlaying = true;
		}
	}
	public void CloseDoor()
	{
		if (isPlaying == false && isOpen == true)
		{
			direction = false;
			currentTime = 0.0f;
			isPlaying = true;
		}
	}

	// Start is called before the first frame update
	void Start()
    {
        openPosition = transform.Find("OpenPosition");
        closePosition = transform.Find("ClosePosition");
        doorObject = transform.Find("Door").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        // Updating animation frames
        if (isPlaying)
        {
            // Calculating progress
            float dt = Time.deltaTime;
            currentTime += dt;
            alpha = currentTime / transitionTime;

			if (direction)
            {
                doorObject.transform.position = Vector3.Lerp(closePosition.position, openPosition.position, CosineEasing(alpha));
            } else
            {
                doorObject.transform.position = Vector3.Lerp(openPosition.position, closePosition.position, CosineEasing(alpha));
            }

            // Completing animation
            if (currentTime >= transitionTime)
            {
                isPlaying = false;
                isOpen = direction;
            }
        }
    }
}
