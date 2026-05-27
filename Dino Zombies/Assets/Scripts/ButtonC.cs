using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonC : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void toTitle()
    {
        SceneManager.LoadScene("Start");
    }

    public void toCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void toGame()
    {
        SceneManager.LoadScene("MainScene");
    }
}
