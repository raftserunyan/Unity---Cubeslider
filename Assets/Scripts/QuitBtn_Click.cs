using UnityEngine;

public class QuitBtn_Click : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quiting game");
    }
}
