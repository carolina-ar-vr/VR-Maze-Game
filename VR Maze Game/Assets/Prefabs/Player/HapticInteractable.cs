using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[System.Serializable]

public class Haptic
{
    [Range(0, 1)]
    public float intensity;
    public float duration;

    public void TriggerHaptic(BaseInteractionEventArgs eventArgs)
    {
        if (eventArgs.interactorObject is XRBaseControllerInteractor controllerInteractor)
        {
            TriggerHaptic(controllerInteractor.xrController);
        }
    }

    public void TriggerHaptic(XRBaseController controller)
    {
        if (intensity > 0)
            controller.SendHapticImpulse(intensity, duration);
    }
}

public class HapticInteractable : MonoBehaviour
{
    public Haptic hapticOnActivated;
    public Haptic hapticHoverEntered;
    public Haptic hapticHoverExited;
    public Haptic hapticSelectEntered;
    public Haptic hapticSelectExited;

    void Start()
    {
        XRBaseInteractable interactbale = GetComponent<XRBaseInteractable>();
        interactbale.activated.AddListener(hapticOnActivated.TriggerHaptic);
        interactbale.hoverEntered.AddListener(hapticHoverEntered.TriggerHaptic);
        interactbale.hoverExited.AddListener(hapticHoverExited.TriggerHaptic);
        interactbale.selectEntered.AddListener(hapticSelectEntered.TriggerHaptic);
        interactbale.selectExited.AddListener(hapticSelectExited.TriggerHaptic);
    }
}
