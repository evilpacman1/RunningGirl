using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawonCube : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] CubePoint;
    public GameObject[] Cube;
    public float TimerRespwon;
    void Start()
    {
        TimerRespwon = 3;
    }
     void Update()
    {
        RespownCube();
    }
    public void RespownCube()
    {

        TimerRespwon -=Time.deltaTime;
        if (TimerRespwon < 0)
        {
            int k =Random.Range(0, CubePoint.Length);
            Instantiate(Cube[k], CubePoint[k].position, CubePoint[k].rotation);
            TimerRespwon = 3;
        }
    }
}
