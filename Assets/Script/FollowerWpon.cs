using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerWpon : CameraFollower
{
    // Start is called before the first frame update
    private float horizontal;

    private void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        if (horizontal < 0f) 
        { 
         transform.rotation = Quaternion.Euler(90, -90f, 0f);
        }
        else
        { 
            transform.rotation = Quaternion.Euler(90, 90f, 0f);
        }
        Move(Time.fixedDeltaTime);
    }
}
