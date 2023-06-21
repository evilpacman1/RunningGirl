using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]
public class Cherector : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] private float _speed = 10f;
    [SerializeField] private float _gravity = -9.81f;
    [SerializeField] private LayerMask _groundMask;
    [SerializeField] private Transform _groundChakerPivot;
    [SerializeField] private float _groundSphereCheck = 0.4f;
    [SerializeField] private float _jumpHeaight = 3;
    private CharacterController _controller;
    public float _velocity;
    private bool _isGrounded;
    private Vector3 _moveDirection;
    public Animator _animator;
    public float Horizontal;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Move(_moveDirection);
        DoGravity();
        _isGrounded = IsOnTheGraund(); 
        if (_isGrounded && _velocity <0) 
        {

            _velocity = -10;
           
        }
        
        AnimatidCherector();
    }
    private void Update()
    {
        _moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        if (Input.GetButtonDown("Jump") && _isGrounded) 
        {
            Jump();
            _animator.SetBool("Jump", true);
        }
        else 
        {
            _animator.SetBool("Jump", false);
        }
    }
    private void Move(Vector3 direction)
    {
        _controller.Move(direction*_speed*Time.fixedDeltaTime);
     //   if (Horizontal < 0)
     //   {
            
            
    //        transform.rotation = Quaternion.Euler(0, 270, 0);
    //    }
    //    if (Horizontal > 0) { transform.rotation = Quaternion.Euler(0, 90, 0); }
    }
    private void Jump() 
    { 
        _velocity = Mathf.Sqrt(_jumpHeaight*-2*_gravity);
    }
    private void DoGravity()
    {
        _velocity += _gravity * Time.fixedDeltaTime;
        _controller.Move(Vector3.up * _velocity* Time.fixedDeltaTime);
    }

    private bool IsOnTheGraund() 
    {
        bool result = Physics.CheckSphere(_groundChakerPivot.position,_groundSphereCheck,_groundMask);
        return result;
    }

    public void AnimatidCherector() 
    {
        Horizontal = Input.GetAxis("Horizontal");
        if(Horizontal < 0) { _animator.SetFloat("h", 1); }
        if(Horizontal > 0) { _animator.SetFloat("h", 1); }
        if(Horizontal == 0) { _animator.SetFloat("h", 1);  }
    
    }

}
