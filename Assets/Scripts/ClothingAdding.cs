using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClothingAdding : MonoBehaviour
{
    public SpriteRenderer part;
    public Sprite[] options;
    public Image thisImage;
    //public Sprite[] clothes;
    //public Sprite[] bodycolor;

    GameObject itemType;

    int index;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < options.Length; i++)
        {
            part.sprite = options[i];
        }
    }
    public void Swap()
    {
        if(index < options.Length - 1)
        {
            index++;
        }
        else
        {
            index = 0;
        }
    }
}
