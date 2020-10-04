using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttion : MonoBehaviour
{
    public Material Green;
    public Material Red;
    public bool ButionOn;
    public bool CanActavateBution;
    public GameObject TelleYouCanActavate;
    public GameObject Bution;
    Renderer rend;
    public bool CanPressBution;
    // Start is called before the first frame update
    void Start()
    {
        CanPressBution = true;
        rend = Bution.GetComponent<SpriteRenderer>();
        rend.enabled = true;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        TelleYouCanActavate.SetActive(true);
        if(collision.gameObject.tag == "Player")
        {
            CanActavateBution = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        TelleYouCanActavate.SetActive(false);
        if (collision.gameObject.tag == "Player")
        {
            CanActavateBution = false;
        }
    }
    void WaitTime()
    {
        CanPressBution = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (CanPressBution == true)
            {
                if(CanActavateBution == true)
                {
                    if (ButionOn == false)
                    {
                        ButionOn = true;
                    }
                    else if (ButionOn == true)
                    {
                        ButionOn = false;
                    }
                }
            }
            
        }
        
        if (ButionOn == true)
        {
            rend.material = Green;
        }
        if (ButionOn == false)
        {
            rend.material = Red;
        }
    }
}
