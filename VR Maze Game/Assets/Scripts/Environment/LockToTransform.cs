using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockToTransform : MonoBehaviour
{
    public Transform lockTo;
    public Vector3 positionOffset = new Vector3(0, 0, 0);

    // Update is called once per frame
    void Update()
    {
        transform.position = lockTo.position + positionOffset;
        transform.rotation = lockTo.rotation;
    }
}
