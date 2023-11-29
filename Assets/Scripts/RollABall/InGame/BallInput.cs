using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallInput : MonoBehaviour

    
{

    public GameObject Ball;
    private Rigidbody ballRigidBody;

    public BallController ballController;

    // Start is called before the first frame update
    void Start()
    {

        ballRigidBody = Ball.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        /**
        // �V����Input System���g�p����"W"�L�[�̓��͂����m
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            Debug.Log("W�L�[��������܂���!");
        }
        // W�L�[�������ꑱ���Ă����
        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("W�L�[�������ꑱ���Ă܂�!");
        }
        // W�L�[�������ꂽ�u�Ԃ����]������
        if (Keyboard.current.wKey.wasReleasedThisFrame)
        {
            Debug.Log("W�L�[��������܂���!");
        }


        // �V����Input System���g�p����"A"�L�[�̓��͂����m
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            Debug.Log("A�L�[��������܂���!");
        }
        if (Keyboard.current.aKey.isPressed)
        {
            Debug.Log("A�L�[�������ꑱ���Ă܂�!");
        }
        if (Keyboard.current.aKey.wasReleasedThisFrame)
        {
            Debug.Log("A�L�[��������܂���!");
        }

        // �V����Input System���g�p����"S"�L�[�̓��͂����m
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            Debug.Log("S�L�[��������܂���!");
        }
        if (Keyboard.current.sKey.isPressed)
        {
            Debug.Log("S�L�[�������ꑱ���Ă܂�!");
        }
        if (Keyboard.current.sKey.wasReleasedThisFrame)
        {
            Debug.Log("S�L�[��������܂���!");
        }

        // �V����Input System���g�p����"D"�L�[�̓��͂����m
        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            Debug.Log("D�L�[��������܂���!");
        }
        if (Keyboard.current.dKey.isPressed)
        {
            Debug.Log("D�L�[�������ꑱ���Ă܂�!");
        }
        if (Keyboard.current.dKey.wasReleasedThisFrame)
        {
            Debug.Log("D�L�[��������܂���!");
        }


        Vector2 mousePosition = Mouse.current.position.ReadValue(); 
        Debug.Log($"�}�E�X�̍��W: {mousePosition}");
        **/

        /**
        if (Keyboard.current.wKey.isPressed)
        {
            ballRigidBody.AddForce(Vector3.forward);
        }
        if (Keyboard.current.aKey.isPressed)
        {
            ballRigidBody.AddForce(Vector3.left);
        }
        if (Keyboard.current.sKey.isPressed)
        {
            ballRigidBody.AddForce(Vector3.back);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            ballRigidBody.AddForce(Vector3.right);
        }
        **/

        if (Keyboard.current.wKey.isPressed)
        {
            ballController.BallMove(Vector3.forward);
        }
        if (Keyboard.current.aKey.isPressed)
        {
            ballController.BallMove(Vector3.left);
        }
        if (Keyboard.current.sKey.isPressed)
        {
            ballController.BallMove(Vector3.back);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            ballController.BallMove(Vector3.right);
        }
    }
}
