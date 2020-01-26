using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class RegisterButton : MonoBehaviour
{
    public string username = "";
    private string password;
    InputField inputU;
    InputField inputP;

    public void registerButtonClick()
    {

        if (username != "")
        {
            username = inputU.name;
        }
        SceneManager.LoadScene(2);//2 = register
    }
    public void logInButtonClick()
    {
        SceneManager.LoadScene(3);//3 = main menu
    }

    private void OnGUI()
    {
        password = GUI.PasswordField(Root (10, 10, 200, 20), inputP.text, "*"[0], 25);
        if(password == "mypass")
        {
            SceneManager.LoadScene(4);
        }
    }
}
