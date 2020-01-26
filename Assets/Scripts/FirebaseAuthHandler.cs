using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proyecto26;

public static class FirebaseAuthHandler
{
    private const string apiKey = "AIzaSyAd7oRNPNjUG6gUt8XbxJaHheb87_ly234";
    public static void SignInWithToken(string idToken, string providerId)
    {
        var payload = $"{{\"postBody\":\"id_token={idToken}&providerId={providerId}\",\"requestUri\":\"http://localhost\",\"returnIdpCredential\":true,\"returnSecureToken\":true}}";

        RestClient.Post($"https://identitytoolkit.googleapis.com/v1/accounts:signInWithCustomToken?key={apiKey}", payload).Then(response =>
        {
            Debug.Log(response.Text);
            //response.Data.
        });
    }
}

