using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RegisterButton : MonoBehaviour
{

    public void registerButtonClick()
    {
        SceneManager.LoadScene(2);//2 = register
    }
    public void logInButtonClick()
    {
        SceneManager.LoadScene(3);//3 = main menu
    }
}
