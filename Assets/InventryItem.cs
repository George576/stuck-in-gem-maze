using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventryItem : MonoBehaviour
{
    public item Item;
    public int SelectNumber;
    public bool isInventryOpen = false;
    public Text Label;
    // Start is called before the first frame update
    void Start()
    {
        Label.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if(isInventryOpen == true)
        {
            Label.text = SelectNumber.ToString();
            Label.gameObject.SetActive(true);
        }
        else
        {
            Label.gameObject.SetActive(false);
        }
    }
}
