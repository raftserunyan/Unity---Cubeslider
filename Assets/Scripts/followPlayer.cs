using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform playerTransform;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playerTransform.position.x, 
            playerTransform.position.y + 2,
            playerTransform.position.z - 4
            );
    }
}
