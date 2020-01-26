using Proyecto26;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GoogleAuthHandler
{
    public static string ClientId = "868804238472-orr2psgjgquefrkr9bu1l0gvevmioutm.apps.googleusercontent.com";
    public static string ClientSecret = "kFVz5Tu4mQzlrmJLkGV5AR8l";
    public static void getUserCode()
    {
        Application.OpenURL($"https://accounts.google.com/o/oauth2/v2/auth?client_id={ClientId}&redirect_uri=urn:ietf:wg:oauth:2.0:oob&response_type=code&scope=email");
    }

    public static void ExchangeAuthCodeWithIdToken(string code, Action<string> callback)
    {
        RestClient.Post($"https://oauth2.googleapis.com/token?code={code}&client_id={ClientId}&client_secret={ClientSecret}&redirect_uri=urn:ietf:wg:oauth:2.0:oob&grant_type=authorization_code", null).Then(response =>
        {
            //response.Text
            var data = StringSerializationAPI.Deserialize(typeof(GoogleIdTokenResponse), response.Text) as GoogleIdTokenResponse;
            callback(data.id_token);
        });
    }
}
