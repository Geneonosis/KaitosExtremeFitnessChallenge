using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SubmitRegistration : MonoBehaviour
{
 
    public void submitButtonClick()
    {
        SceneManager.LoadScene(1);//1 = log in
    }
}
