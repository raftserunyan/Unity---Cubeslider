using UnityEngine;

public class playerControl : MonoBehaviour
{
    public Rigidbody playerRigit;
    public Transform playerTransform;
    public float forwardSpeed = 5000f;
    public float sidewaysSpeed = 70f;
    public float acceleration = 8f;

    private float forwardSpeedAtBeginning = 5000f;

    void FixedUpdate()
    {
        float distance = playerTransform.position.z - 8;
        forwardSpeed = forwardSpeedAtBeginning + (distance * acceleration);


        playerRigit.AddForce(0, 0, forwardSpeed * Time.deltaTime);

        if(Input.GetKey("a"))
        {
            playerRigit.AddForce(-sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if(Input.GetKey("d"))
        {
            playerRigit.AddForce(sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(transform.position.y < -1)
        {
            FindObjectOfType<GameController>().GameOver();
        }
    }
}
