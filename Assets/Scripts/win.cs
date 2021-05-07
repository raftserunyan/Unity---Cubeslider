using UnityEngine;

public class win : MonoBehaviour
{
    void OnTriggerEnter()
    {
        FindObjectOfType<GameController>().GameWon();
    }
}
