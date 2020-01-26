using System.Collections;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.__Networking__;
using UnityEngine.Networking;
//using Google.Apis.Auth.OAuth2;
//using Google.Apis.Services;
//using Google.Apis.Util.Store;



public class GoogleFitnessREST : MonoBehaviour
{
    [SerializeField]
    GameObject messagingPanel = null;
    void Start()
    {
        Debug.Log("Books API Sample: List MyLibrary");
        Debug.Log("================================");
        //StartCoroutine(setupAPI());
    }

    //IEnumerator setupAPI()
    //{
    //    UserCredential credential;
    //    using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
    //    {
    //        //credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets { }, null, CancellationToken.None);
    //    }
    //}
}
