using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respowntrinagle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] triangle;
    public Transform _respownTriangle;
    public float _timerTriangle;


    // Update is called once per frame
    private void Start()
    {
        _timerTriangle = 3;
    }
    void Update()
    {
        TriangleRescpown();
    }


    private void TriangleRescpown() 
    {

        _timerTriangle -= Time.deltaTime;
        if (_timerTriangle < 0) 
        { 
            int k = Random.Range(0, triangle.Length);
            Instantiate(triangle[k], _respownTriangle.position,_respownTriangle.rotation);
            _timerTriangle = 3;
        }
    
    }
}
