using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatetest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool rotate=false;
        Debug.Log(rotate.ToString());
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rotate = true;
            Debug.Log("space basýldý" + rotate.ToString()) ;
        }
        else if (rotate == true && Input.GetKeyDown(KeyCode.Space))
        {
            rotate = false;
        }
        do
        {
            Vector2 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
            transform.rotation = rotation;
            if (Input.GetKeyDown(KeyCode.R))
            {
                rotate = false;
            }
        } while (rotate == false);
        
    }
}
