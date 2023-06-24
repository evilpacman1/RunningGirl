using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    public float _speed = 5;
    //  public Rigidbody _rb;
    public float _timetLife;
    void Start()
    {
        _timetLife = 25;
       /// _rb.velocity = transform.right * _speed;
    }
    private void Update()
    {
        if (_timetLife < 0) 
        { 
            
            Destroy(gameObject);
            
        }
        transform.Translate(Vector3.right * _speed* Time.deltaTime);
    }

}
