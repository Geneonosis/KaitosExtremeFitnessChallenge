using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformAvatar : MonoBehaviour
{

    public GameObject avatar;
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Transform()
    {
        //avatar.GetComponent<Animation>().enabled = false;
        button.transform.position = new Vector2(0, 1.8f);
        //Debug.Log(button.transform.position);
    }
    public void TransformBack()
    {
        button.transform.position = new Vector2(0, -0.5f);
        //avatar.GetComponent<Animation>().enabled = true;
    }

}
