using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private CharacterController _controller;
    private Animator _anim;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        _anim = GetComponentInChildren<Animator>();
    }

    void Start()
    {
        _controller.OnAttackEvent += OnShoot;
    }

    private void OnShoot()
    {
        CreateProjectile();
    }

    private void CreateProjectile()
    {
        _anim.SetTrigger("Attack");
    }
}

