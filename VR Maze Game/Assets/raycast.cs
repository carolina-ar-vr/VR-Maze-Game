using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class raycast : MonoBehaviour
{
    // Start is called before the first frame update
    GraphicRaycaster raycaster;
    void Start()
    {
        this.raycaster = GetComponent<GraphicRaycaster>();
    }

    // Update is called once per frame
    public void OnPointerClick()
    {
        Debug.Log("Canvas clicked");
    }
}
