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
        // 新しいInput Systemを使用して"W"キーの入力を検知
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            Debug.Log("Wキーが押されました!");
        }
        // Wキーが押され続けている間
        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("Wキーが押され続けてます!");
        }
        // Wキーが離された瞬間だけ評価する
        if (Keyboard.current.wKey.wasReleasedThisFrame)
        {
            Debug.Log("Wキーが離されました!");
        }


        // 新しいInput Systemを使用して"A"キーの入力を検知
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            Debug.Log("Aキーが押されました!");
        }
        if (Keyboard.current.aKey.isPressed)
        {
            Debug.Log("Aキーが押され続けてます!");
        }
        if (Keyboard.current.aKey.wasReleasedThisFrame)
        {
            Debug.Log("Aキーが離されました!");
        }

        // 新しいInput Systemを使用して"S"キーの入力を検知
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            Debug.Log("Sキーが押されました!");
        }
        if (Keyboard.current.sKey.isPressed)
        {
            Debug.Log("Sキーが押され続けてます!");
        }
        if (Keyboard.current.sKey.wasReleasedThisFrame)
        {
            Debug.Log("Sキーが離されました!");
        }

        // 新しいInput Systemを使用して"D"キーの入力を検知
        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            Debug.Log("Dキーが押されました!");
        }
        if (Keyboard.current.dKey.isPressed)
        {
            Debug.Log("Dキーが押され続けてます!");
        }
        if (Keyboard.current.dKey.wasReleasedThisFrame)
        {
            Debug.Log("Dキーが離されました!");
        }


        Vector2 mousePosition = Mouse.current.position.ReadValue(); 
        Debug.Log($"マウスの座標: {mousePosition}");
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
