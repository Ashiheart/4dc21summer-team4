using UnityEngine.SceneManagement;
using UnityEngine;

public class SelectButton2 : MonoBehaviour
{
    [SerializeField] private AudioClip choose;

    [SerializeField] private AudioClip down;

    public void ButtonChose()
    {
        GetComponent<AudioSource>().PlayOneShot(choose);
    }

    public void ClickRetryGame()
    {
        GetComponent<AudioSource>().PlayOneShot(down);
        SceneManager.LoadScene("InGame");
    }

    public void ClickTitleGame()
    {
        GetComponent<AudioSource>().PlayOneShot(down);
        SceneManager.LoadScene("Title");
    }
}

