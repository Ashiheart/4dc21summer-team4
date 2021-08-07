using UnityEngine.SceneManagement;
using UnityEngine;

public class SelectButton2 : MonoBehaviour
{
    public void ClickRetryGame()
    {
        SceneManager.LoadScene("InGame");
    }

    public void ClickTitleGame()
    {
        SceneManager.LoadScene("Title");
    }
}

