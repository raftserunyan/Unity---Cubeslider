using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestartBtn_Click : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("LoadingGame");
    }
}
