using UnityEngine.SceneManagement;
using UnityEngine;

public class SelectButton : MonoBehaviour 
{
    public void ClickStartGame()
    {
        SceneManager.LoadScene("InGame");
    }

    public void ClickEndGame()
    {
        ExitGame.ExitImm();
    }
}
