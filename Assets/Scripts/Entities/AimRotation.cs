using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimRotation : MonoBehaviour
{

    [SerializeField] private SpriteRenderer characterRenderer;

    private CharacterController _controller;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    public void OnAim(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        
        // ���콺 ��ġ�� ���� ĳ���� ��������Ʈ ������ ��ȯ
        if(Mathf.Abs(rotZ) > 90f)
        {
            characterRenderer.transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            characterRenderer.transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
