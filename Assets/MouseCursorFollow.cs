using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursorFollow : MonoBehaviour
{
    // public float speed = 5f;
    public bool restrictY = false;
    public bool restrictX = false;
    Rigidbody2D rb;
    Vector2 mousePosition;
    Camera mycam;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mycam = FindObjectOfType<Camera>();
    }

    
    void Update()
    {
        mousePosition = mycam.ScreenToWorldPoint(Input.mousePosition);
        if(restrictX && restrictY == false){
            rb.MovePosition(new Vector2(rb.position.x, mousePosition.y));
        }
        else if(restrictY && restrictX == false){
            rb.MovePosition(new Vector2(mousePosition.x, rb.position.y));
        }
        else if(restrictX && restrictY)
        {
            return;
        }
        else{
            rb.MovePosition(mousePosition);
        }
        // transform.position = Vector2.MoveTowards(transform.position, mousePosition, speed * Time.deltaTime);
    }
}
