using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody ballRigiBody;
    void Start()
    {
        ballRigiBody = GetComponent<Rigidbody>();
        var ballData = new BallData(5);
        Debug.Log(ballData.GetHitPoint); //5
    }

    public void BallMove(Vector3 direction)
    {
        ballRigiBody.AddForce(direction);
    }
    private void OnCollisionEnter(Collision collision)
    {
        // Kiểm tra nếu va chạm xảy ra với đối tượng có tên là "Cube"
        if (collision.gameObject.name == "Cube")
        {
            // In ra "Damage"
            Debug.Log("Damage");
        }
    }
    
    // Update is called once per frame
    void Update()
    {
    }
}
