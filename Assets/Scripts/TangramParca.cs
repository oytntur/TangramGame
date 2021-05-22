using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangramParca : MonoBehaviour
{
    [SerializeField]
    GameController GM;
    
    public void OnMouseDown()
    {
        Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);

        if (hit)
        {
            Debug.Log(hit.transform.name);
            GM.obje = hit.transform.gameObject;
        }


    }
    //TODO:Sað týk ile parça býrakma
    //public void OnMouseUp()
    //{
    //    GM.obje = null;
    
    //}
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
