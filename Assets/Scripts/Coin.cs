using UnityEngine;

public class Coin : MonoBehaviour
{
    GameController gc;

    [SerializeField]
    float rotationSpeed = 150;
    [SerializeField]
    float verticalSpeed = 0.4f;
    [SerializeField]
    float MinY = 1.1f;
    [SerializeField]
    float MaxY = 1.4f;

    byte direction = 1;

    void Awake()
    {
        gc = GameObject.FindObjectOfType<GameController>();
    }

    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);

        Vector3 pos = transform.position;
        float coinY = pos.y;

        if (direction == 1)
        {
            pos.y += verticalSpeed * Time.deltaTime;
        }
        else if(direction == 0)
        {
            pos.y -= verticalSpeed * Time.deltaTime;
        }

        if (coinY >= MaxY)
            direction = 0;
        else if (coinY <= MinY)
            direction = 1;

        transform.position = pos;
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Player")
        {
            gc.IncrementCoinsQuantity();
        }

        Destroy(this.gameObject);
    }
}
