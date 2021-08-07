using UnityEngine.SceneManagement;
using UnityEngine;

public class SelectButton : MonoBehaviour 
{
    [SerializeField] private AudioClip choose;

    [SerializeField] private AudioClip down;

    public void ButtonChose()
    {
        GetComponent<AudioSource>().PlayOneShot(choose);
    }

    public void ClickStartGame()
    {
        SceneManager.LoadScene("InGame");
    }

    public void ClickEndGame()
    {
        ExitGame.ExitImm();
    }

    public void ClickShowCredit()
    {
        GameObject.Find("Credit").GetComponent<SpriteRenderer>().enabled = true;
    }
}
