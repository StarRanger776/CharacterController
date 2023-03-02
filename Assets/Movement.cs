using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _walkSpeed;
    [SerializeField] private float _RunSpeed;

    Animator _anim;
    CharacterController _controller;

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _controller.Move(move * Time.deltaTime * _moveSpeed);

        if(move != Vector3.zero)
        {
            transform.forward = move;
            _anim.SetFloat("Forward", 1f, 0.1f, Time.deltaTime);
        }
        else
        {
            _anim.SetFloat("Forward", 0, 0.1f, Time.deltaTime);
        }
    }
}
