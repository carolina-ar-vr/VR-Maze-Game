using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockableObject : MonoBehaviour
{
    public void LockObject()
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }
    public void UnlockObject()
    {
        GetComponent<Rigidbody>().isKinematic = false;
    }
}
