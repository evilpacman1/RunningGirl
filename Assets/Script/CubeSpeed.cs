using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CubeSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    public float _speed =10f;
    //  public Rigidbody _rb;
    
    public float _timerTime;
    void Start()
    {
  
        _timerTime = 25;
       
}
    private void Update()
    {
        _timerTime -= Time.deltaTime;
        LevelSpeed();
        if (_timerTime < 0)
        {

            Destroy(gameObject);

        }
        transform.Translate(Vector3.down * _speed* Time.deltaTime);
       
    }
    public void LevelSpeed()
    {

        _speed = PlayerPrefs.GetFloat(Sorce.saveSpeed);


    }

}
