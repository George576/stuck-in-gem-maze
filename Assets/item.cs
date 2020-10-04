using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public bool PlayerHasItme;
    public bool CanGetItem;
    public GameObject itemOnCanvas;
    public GameObject Theitem;
    public GameObject CanGetTeller;
    // Start is called before the first frame update
    void Start()
    {
        PlayerHasItme = false;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        CanGetTeller.SetActive(true);
        if (collision.gameObject.tag == "Player")
        {
            CanGetItem = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        CanGetTeller.SetActive(false);
        if (collision.gameObject.tag == "Player")
        {
            CanGetItem = false;
        }
    }

    public void Drop()
    {
        var player = FindObjectOfType<MoveMent>();
        gameObject.transform.position = player.transform.position;
        PlayerHasItme = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            if(CanGetItem == true)
            {
                PlayerHasItme = true;   
            }

        }
        if (PlayerHasItme == true)
        {
            itemOnCanvas.SetActive(true);
            Theitem.SetActive(false);
        }
        if (PlayerHasItme == false)
        {
            itemOnCanvas.SetActive(false);
            Theitem.SetActive(true);
        }
    }
}
