using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogoLoading : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(1); // 0 = loading, 1 = log in

    }
}
