using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClothingAdding : MonoBehaviour
{
    public Sprite image;
    public GameObject Head;
    public GameObject Shirt;
    public GameObject Weapon;
    public GameObject Soccer;
    public GameObject FullBody;

    //public Sprite[] clothes;
    //public Sprite[] bodycolor;

    //GameObject itemType;

    int index;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    
   
    public void Change()
    {
        if (tag.Equals("Head"))
        {
            if (Head.GetComponent<Image>().enabled != true)
            {
                Head.GetComponent<Image>().enabled = true;

            }
            Head.GetComponent<Image>().overrideSprite = image;
            

        }
        else if (tag.Equals("Shirt"))
        {
            if (Shirt.GetComponent<Image>().enabled != true)
            {
                Shirt.GetComponent<Image>().enabled = true;
            }
            Shirt.GetComponent<Image>().overrideSprite = image;
            
        }
        else if (tag.Equals("Weapon"))
        {
            if (Weapon.GetComponent<Image>().enabled != true)
            {
                Weapon.GetComponent<Image>().enabled = true;
            }
            if(Soccer.GetComponent<Image>().enabled == true)
            {
                Soccer.GetComponent<Image>().enabled = false;
            }
            Weapon.GetComponent<Image>().overrideSprite = image;
        }
        else if (tag.Equals("Soccer"))
        {
            if (Soccer.GetComponent<Image>().enabled != true)
            {
                Soccer.GetComponent<Image>().enabled = true;
            }
            if (Weapon.GetComponent<Image>().enabled == true)
            {
                Weapon.GetComponent<Image>().enabled = false;
            }
            Soccer.GetComponent<Image>().overrideSprite = image;
        }
        else if (tag.Equals("Avatar"))
        {
            if (FullBody.GetComponent<Image>().enabled != true)
            {
                FullBody.GetComponent<Image>().enabled = true;
            }
            FullBody.GetComponent<Image>().overrideSprite = image;
        }
        else
        {
            print("system fail");
        }
    }
}
