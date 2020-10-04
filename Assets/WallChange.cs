using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallChange : MonoBehaviour
{
    public bool Switch;
    public GameObject onWall;
    public GameObject offWall;
    // Start is called before the first frame update
    void Start()
    {
        Switch = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Gem")
        {
            Switch = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Gem")
        {
            Switch = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        //var player = FindObjectsOfType<item>();
        if (Switch == false)
        {
            onWall.SetActive(true);
            offWall.SetActive(false);

        }
        if (Switch == true)
        {
            onWall.SetActive(false);
            offWall.SetActive(true);

        }
    }
}
