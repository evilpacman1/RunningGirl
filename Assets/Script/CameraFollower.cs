using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform _targetTransform;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _smooting =1f;

    protected private void Move(float DeltaTime) 
    { 
      var nextPosition = Vector3.Lerp(transform.position, _targetTransform.position+_offset, DeltaTime *_smooting);
        transform.position = nextPosition;
     
    }
    
}
