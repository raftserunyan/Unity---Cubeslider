using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlRestartButton_Click : MonoBehaviour
{
    public void RestartLastLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("LoadingLastLevel");
    }
}
