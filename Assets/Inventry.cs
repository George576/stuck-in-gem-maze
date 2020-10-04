using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Inventry : MonoBehaviour
{
    public bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            isOpen = !isOpen;

            if(isOpen)
            {
                OpenInventry();
            }
            else
            {
                CloseInventry();
            }

        }
        if(isOpen == true)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                SelectItem(1);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                SelectItem(2);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                SelectItem(3);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                SelectItem(4);
            }

        }
    }
    private void SelectItem(int number)
    {
        var item = GetComponentsInChildren<InventryItem>()
            .FirstOrDefault(i => i.SelectNumber == number);
        item.Item.Drop();

        isOpen = false;
        CloseInventry();
    }
    private void CloseInventry()
    {
        var items = GetComponentsInChildren<InventryItem>();
        for (var i = 0; i < items.Length; i++)
        {
            var item = items[i];
            item.isInventryOpen = false;
        }

        var image = GetComponent<Image>();
        image.enabled = false;
    }
    private void OpenInventry()
    {
        var items = GetComponentsInChildren<InventryItem>();
        for (var i = 0; i < items.Length; i++)
        {
            var item = items[i];
            item.SelectNumber = i + 1;
            item.isInventryOpen = true;
        }

        var image = GetComponent<Image>();
        image.enabled = true;
    }
}
