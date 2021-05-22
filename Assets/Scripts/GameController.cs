using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject obje;
    public float speed;
    void Start()
    {
        
    }


    void Update()
    {
        
        if (obje != null)
        {
            Vector3 pos = obje.transform.position;
            if (Input.GetKey("w"))
            {
                pos.y += speed * Time.deltaTime;
            }
            if (Input.GetKey("s"))
            {
                pos.y -= speed * Time.deltaTime;
            }
            if (Input.GetKey("d"))
            {
                pos.x += speed * Time.deltaTime;
            }
            if (Input.GetKey("a"))
            {
                pos.x -= speed * Time.deltaTime;
            }
            obje.transform.position = pos;
            if (Input.GetKey("q"))
            {
                obje.transform.Rotate(Vector3.forward*Time.deltaTime*2*speed);
            }
            if (Input.GetKey("e"))
            {
                obje.transform.Rotate(Vector3.back*Time.deltaTime*2*speed);
            }
            if (Input.GetKey("r"))
            {
                obje.transform.rotation= Quaternion.identity;
            }
        }
    }

}
