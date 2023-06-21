using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wepone : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    public GameObject bullet;
    void Start()
    {
        
    }

    public void Shoting()
    {

        Instantiate(bullet,firePoint.position,firePoint.rotation);
    }
}
