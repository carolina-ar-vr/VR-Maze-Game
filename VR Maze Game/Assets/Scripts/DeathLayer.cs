using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathLayer : MonoBehaviour
{
    // Public variables
    public Transform playerTransform;
    public Transform respawn;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (playerTransform.position.y <= transform.position.y)
        {
            Debug.Log("Respawn plz");
            playerTransform.position = respawn.position;
        }
    }
}
