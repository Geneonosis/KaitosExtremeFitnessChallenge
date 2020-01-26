using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapDamager : MonoBehaviour
{
    int damage;
    [SerializeField] GameObject boss = null;
    [SerializeField] AnimationClip damageBossAnimation = null;
    public void tapDamage()
    {
        boss.GetComponent<Animation>().clip = damageBossAnimation;
        boss.GetComponent<Animation>().Play();
        Debug.Log("apply damage");
    }
}
