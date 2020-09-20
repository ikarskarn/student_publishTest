using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalNodes : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer sr;
    public Sprite none;
    public Sprite left;
    public Sprite right;
    public string current;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = none;
        SwitchSprite(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Add new Function here
    void SwitchSprite()
    {
        if(current == "left")
        {
            Debug.Log("Choose Left");
            sr.sprite = left;
        }
        else if (current == "right")
        {
            Debug.Log("Choose Right");
            sr.sprite = right;
        }
        else
        {
            Debug.Log("Choose None");
            sr.sprite = none;
        }
    }

   
}


