using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    bool isDragging;
    public GameController GM;
    public GameObject Object;
    public void OnMouseDown()
    {
        isDragging = true;
        
        //GM.obje = Object;
    }
    public void OnMouseUp()
    {
        isDragging = false;
        //GM.obje = null;
    }
    

    // Update is called once per frame
    void Update()
    {
        //if (isDragging)
        //{
        //    Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        //    transform.Translate(mousePosition);
        //}
        

    }
}
