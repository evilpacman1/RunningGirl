using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float _speed = 5f;
    public Rigidbody rb;
    void Start()
    {
        rb.velocity = -transform.right * _speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        Destroy(gameObject);
    }
    // Update is called once per frame

}
