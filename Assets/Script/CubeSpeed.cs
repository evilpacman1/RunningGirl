using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    public float _speed;
    public Rigidbody _rb;
    void Start()
    {
        _rb.velocity = transform.right * _speed;
    }
    private void Update()
    {
        transform.Translate(Vector3.right * _speed* Time.deltaTime);
    }

}
