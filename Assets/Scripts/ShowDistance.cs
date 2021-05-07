using UnityEngine;
using UnityEngine.UI;

public class ShowDistance : MonoBehaviour
{
    public Transform playerTransform;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        //-8 is for starting to count after player crossed the start line
        float distance = playerTransform.position.z - 8;

        if (distance < 0)
            scoreText.text = "0";
        else
            scoreText.text = distance.ToString("0"); 

    }
}
