using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathLayer : DeathObject
{
    // Update is called once per frame
    void FixedUpdate()
    {
        if (playerTransform.position.y <= transform.position.y)
        {
            KillPlayer();
        }
    }
}
