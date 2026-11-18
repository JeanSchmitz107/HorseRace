using UnityEditor.Build;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rbPlayer;
    [SerializeField] private float speed = 3.0f;
    [SerializeField] private float speed_slide = 3.0f;

    void FixedUpdate()
    {
        rbPlayer.AddForce(0.0f, 0.0f, speed);
        if (Input.GetKey(KeyCode.Q))
        {
            rbPlayer.AddForce(-speed_slide, 0.0f, 0.0f, ForceMode.VelocityChange);
        }

        if(Input.GetKey(KeyCode.D))
        {
            rbPlayer.AddForce(speed_slide, 0.0f, 0.0f, ForceMode.VelocityChange);
        }

    }
}
