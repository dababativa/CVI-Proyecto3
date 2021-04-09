using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camisa : MonoBehaviour
{
    public System.Timers.Timer timer;
    Texture2D shirtTexture1;
    Texture2D shirtTexture2;
    Texture2D shirtTexture3;
    GameObject shirt;
    GameObject mangaIzquierda;
    GameObject mangaDerecha;
    public int counter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        shirtTexture1 = Resources.Load<Texture2D>("Textures/tiedye");
        shirtTexture2 = Resources.Load<Texture2D>("Textures/zebra");
        shirtTexture3 = Resources.Load<Texture2D>("Textures/abstract");
        shirtTexture1.wrapMode = TextureWrapMode.Repeat;
        shirtTexture2.wrapMode = TextureWrapMode.Mirror;
        shirtTexture3.wrapMode = TextureWrapMode.Clamp;

        print("done");

       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            counter++;
            if (shirt != null)
            {
                Destroy(shirt, 0);
            }

            if (mangaIzquierda != null)
            {
                Destroy(mangaIzquierda, 0);
            }

            if (mangaDerecha != null)
            {
                Destroy(mangaDerecha, 0);
            }

            shirt = GameObject.CreatePrimitive(PrimitiveType.Cube);
            shirt.transform.position = new Vector3(-0.0352942f, 1, -8.334f);
            shirt.transform.localScale = new Vector3(0.3f, 0.4f, 0.01f);

            mangaIzquierda = GameObject.CreatePrimitive(PrimitiveType.Cube);
            mangaIzquierda.transform.position = new Vector3(-0.2185942f, 1.0788f, -8.328799f);
            mangaIzquierda.transform.localScale = new Vector3(0.1f, 0.2f, 0.01f);
            mangaIzquierda.transform.Rotate(0, 0, -53.25f, Space.Self);

            mangaDerecha = GameObject.CreatePrimitive(PrimitiveType.Cube);
            mangaDerecha.transform.position = new Vector3(0.1495058f, 1.0796f, -8.3322f);
            mangaDerecha.transform.localScale = new Vector3(0.1f, 0.2f, 0.01f);
            mangaDerecha.transform.Rotate(0, 0, 53.25f, Space.Self);

            print("me creo");
            if (counter % 3 == 1)
            {
                shirt.GetComponent<Renderer>().material.mainTexture = shirtTexture1;
                mangaIzquierda.GetComponent<Renderer>().material.mainTexture = shirtTexture1;
                mangaDerecha.GetComponent<Renderer>().material.mainTexture = shirtTexture1;

            }
            else if (counter % 3 == 2)
            {
                shirt.GetComponent<Renderer>().material.mainTexture = shirtTexture2;
                mangaIzquierda.GetComponent<Renderer>().material.mainTexture = shirtTexture2;
                mangaDerecha.GetComponent<Renderer>().material.mainTexture = shirtTexture2;
            }
            else if (counter % 3 == 0)
            {
                
                shirt.GetComponent<Renderer>().material.mainTexture = shirtTexture3;
                mangaIzquierda.GetComponent<Renderer>().material.mainTexture = shirtTexture3;
                mangaDerecha.GetComponent<Renderer>().material.mainTexture = shirtTexture3;
            }

        }
    }


    void ChangeTexture()
    {

        

    }
}
