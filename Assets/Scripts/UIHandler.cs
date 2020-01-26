using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField] InputField code;
    // Start is called before the first frame update
    public void onClickGoogleCode()
    {
        GoogleAuthHandler.getUserCode();
    }
    public void onClickGoogleSignIn()
    {
        GoogleAuthHandler.ExchangeAuthCodeWithIdToken(code.text, idToken =>
        {
            FirebaseAuthHandler.SignInWithToken(idToken, "google.com");
        });
    }
}
