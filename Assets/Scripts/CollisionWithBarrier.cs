using UnityEngine;

public class CollisionWithBarrier : MonoBehaviour
{
    public GameObject panel;

    void OnCollisionEnter(Collision colInfo)
    {
        if (colInfo.collider.tag == "Barrier")
        {
            FindObjectOfType<GameController>().GameOver();
        }
    }
}
