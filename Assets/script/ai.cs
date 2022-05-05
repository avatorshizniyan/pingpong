using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai : MonoBehaviour
{
    float speed = 30;
    public GameObject ball;
    public GameObject ball2;
    float ball_y  = 0;
    float ball_x  = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
       float ball_y  = ball.transform.position.y;
       float ball_x  = ball.transform.position.x;
       float ball2_y  = ball2.transform.position.y;
       float ball2_x  = ball2.transform.position.x;
       
       float rocket_y = transform.position.y;
       float rocket_x = transform.position.x;
       float rocket_h = GetComponent<BoxCollider2D>().transform.localScale.y;
       float direction;

       if (rocket_x - ball_x > rocket_x - ball2_x)
       {
           ball_x = ball2_x;
           ball_y = ball2_y;
       }

       else 
       {
           ball_x = ball_x;
           ball_y = ball_y;
       }
       if(ball_x > 0  )
       {
            if(ball_y + rocket_h < rocket_y)
            {
                    direction=-1;
            }
            else if(ball_y - rocket_h > rocket_y)
            {
                    direction= +1;
            }
                else 
                {
                    direction= 0;
                }
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, direction) * speed;
            
       }
     }
      
}
