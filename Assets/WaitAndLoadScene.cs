using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class WaitAndLoadScene : MonoBehaviour
{
    [SerializeField] float seconds = 3;
    [SerializeField] float timeBetweenDots = 0.1F;
    [SerializeField] TextMeshProUGUI dotdotdot;
    private string threeDots = "";
    private bool transitionTrigger = true;
    private void Start()
    {
        seconds = 3;
        timeBetweenDots = 0.1F;
        StartCoroutine(WaitForALittleBit(seconds));
    }

    private void Update()
    {
        if (transitionTrigger)
        {
            StartCoroutine(WaitForALittleBitDots(timeBetweenDots));
            //Debug.Log("test");
            threeDots += ".";
            dotdotdot.SetText(threeDots);
        }
        if(threeDots.Length == 4)
        {
            threeDots = "";
            dotdotdot.SetText(threeDots);
        }
    }

    IEnumerator WaitForALittleBitDots(float ammount)
    {
        transitionTrigger = false;
        yield return new WaitForSeconds(ammount);
        transitionTrigger = true;
    }
    IEnumerator WaitForALittleBit(float ammount)
    {
        yield return new WaitForSeconds(ammount);
        SceneManager.LoadScene(1);
    }
}
