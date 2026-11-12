using UnityEditor.Build;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rbPlayer;
    [SerializeField] private float speed = 3.0f;

    void FixedUpdate()
    {

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rbPlayer.AddForce(-10.0f, 0.0f, 0.0f);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            rbPlayer.AddForce(10.0f, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rbPlayer.AddForce(0.0f, 0.0f, Time.fixedDeltaTime * speed);
        }
    }
}
