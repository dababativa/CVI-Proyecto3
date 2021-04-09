using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cortina : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Texture cortinaTexture = Resources.Load<Texture>("Textures/leopardo");
        gameObject.GetComponent<Renderer>().material.mainTexture = cortinaTexture;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        { 
            gameObject.GetComponent<Animator>().Play("Base Layer.CortinaAnimation", 0, 0);
        }
    }
}
