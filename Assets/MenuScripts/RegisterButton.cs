using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class RegisterButton : MonoBehaviour
{
    public string username = "";
    private string password;
    public Text inputU;
    public InputField inputP;
    //Text text = "nope";
    

    public void registerButtonClick()
    {

        if (username != "")
        {
            username = inputU.name;
            password = inputP.name;
            print(username);
            print(password);
        }
        SceneManager.LoadScene(2);//2 = register
    }
    public void logInButtonClick()
    {
        SceneManager.LoadScene(3);//3 = main menu
    }

    private void OnGUI()
    {
       // password = GUI.PasswordField(Rect (10, 10, 200, 20), inputP.text, "*"[0], 25);
        if(password == "mypass")
        {
            SceneManager.LoadScene(4);
        }
    }
}
