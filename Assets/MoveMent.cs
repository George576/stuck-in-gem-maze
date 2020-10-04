using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent : MonoBehaviour
{
    public float speed;
    private float moveingSpeed;
    public float RunDigres;
    public Rigidbody2D RG;
    public bool MovedLeft;
    public GameObject RightPlayer;
    public GameObject leftPlayer;
    //public GameObject RightPlayerStop;
    //public GameObject leftPlayerStop;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        var vel = RG.velocity;
        moveingSpeed = vel.magnitude;
        //if(!Input.GetKey(KeyCode.LeftArrow) || !Input.GetKey(KeyCode.A) || !Input.GetKey(KeyCode.RightArrow) || !Input.GetKey(KeyCode.D))
        //{
        //    if (MovedLeft == true)
        //    {
        //        leftPlayerStop.SetActive(true);
        //        RightPlayerStop.SetActive(false);
        //        RightPlayer.SetActive(false);
        //        leftPlayer.SetActive(false);
        //    }
        //    if (MovedLeft == false)
        //    {
        //        RightPlayerStop.SetActive(true); 
        //        leftPlayerStop.SetActive(false);
        //        RightPlayer.SetActive(false);
        //        leftPlayer.SetActive(false);
        //    }
        //}
        

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            //gameObject.transform.rotation = Quaternion.Euler(0,0,RunDigres);
            //gameObject.transform.rotation = Quaternion.Euler(0, 0, moveingSpeed * 3.5f);
            //RG.velocity = new Vector2(-speed, 0);
            transform.position += Vector3.right * -speed * Time.deltaTime; 
            RightPlayer.SetActive(true);
            leftPlayer.SetActive(false);
            //leftPlayerStop.SetActive(false);
            ///RightPlayerStop.SetActive(false);
            MovedLeft = true;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            //gameObject.transform.rotation = Quaternion.Euler(0, 0, -RunDigres);
            //gameObject.transform.rotation = Quaternion.Euler(0, 0, -moveingSpeed * 3.5f);
            //RG.velocity = new Vector2(speed, 0);
            transform.position += Vector3.right * speed * Time.deltaTime;
            RightPlayer.SetActive(false);
            leftPlayer.SetActive(true); 
            //leftPlayerStop.SetActive(false);
            //RightPlayerStop.SetActive(false);
            MovedLeft = false;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            //gameObject.transform.rotation = Quaternion.Euler(0, 0, -RunDigres);
            //gameObject.transform.rotation = Quaternion.Euler(0, 0, -moveingSpeed * 3.5f);
            //RG.velocity = new Vector2(speed, 0);
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            //gameObject.transform.rotation = Quaternion.Euler(0, 0, -RunDigres);
            //gameObject.transform.rotation = Quaternion.Euler(0, 0, -moveingSpeed * 3.5f);
            //RG.velocity = new Vector2(speed, 0);
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
    }
}
