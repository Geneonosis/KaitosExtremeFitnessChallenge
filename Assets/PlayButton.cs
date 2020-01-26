using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void playButtonClick()
    {
        SceneManager.LoadScene(4);//4 = play menu
    }
    public void settingsButtonClick()
    {
        SceneManager.LoadScene(5);//5 = settings
    }
}
