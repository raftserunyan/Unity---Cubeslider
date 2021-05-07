using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Rigidbody rigit;
    public GameObject panel;
    public Text panelText;
    public Text buttonText;
    public Button btn;
    public Text Coins;
    private int score = 0;

    public void IncrementCoinsQuantity()
    {
        score++;
        Coins.text = score.ToString();
    }

    public void GameOver()
    {
        panelText.text = "You Lost!";
        buttonText.text = "Try Again";

        btn.onClick.RemoveAllListeners();
        btn.onClick.AddListener(Restart);

        FindObjectOfType<playerControl>().enabled = false;
        panel.SetActive(true);
        rigit.drag = 3f;
    }

    public void GameWon()
    {
        panelText.text = "You Won!";
        buttonText.text = "Next level";

        btn.onClick.RemoveAllListeners();
        btn.onClick.AddListener(LoadNextLevel);

        FindObjectOfType<playerControl>().enabled = false;
        panel.SetActive(true);
        rigit.drag = 3f;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
