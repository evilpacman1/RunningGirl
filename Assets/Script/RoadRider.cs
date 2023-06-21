using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadRider : MonoBehaviour
{
    // Start is called before the first frame update
    private float offset;

   
    // Update is called once per frame
    void Update()
    {
        offset -= 0.01f;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offset, 0f);
    }
}
