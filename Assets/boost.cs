using UnityEngine;
using System.Collections;

public class boost : MonoBehaviour
{

    public float topSpeed = 10f;
    public float drag = 0f;
    public float acceleration = 10f;
    private Vector3 velocity;
    public float currentSpeed;
    public GameObject ball;

    void OnCollisionStay(Collision collisionInfo)
        {
            Debug.Log("ENTERED");
       // foreach (ContactPoint contact in collision.contacts)
        //{
            drag = (acceleration / topSpeed);
        //ball.GetComponent<Rigidbody>().velocity += (Vector3.right * acceleration - (drag * velocity)) * Time.fixedDeltaTime;
        ball.GetComponent<Rigidbody>().velocity *= 1.06f;
       // ball.transform.position += velocity * Time.fixedDeltaTime;
            currentSpeed = velocity.magnitude;


//        }

    
    }

  
}