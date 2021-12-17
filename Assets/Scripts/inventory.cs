using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    private bool inventoryEnable;
    public GameObject inventory1;

    private int allSlots;

    private int enableSlot;

    private GameObject[] slot;

    public GameObject slotHolder;
    // Start is called before the first frame update
    void Start()
    {
        allSlots = slotHolder.transform.childCount;
        slot = new GameObject[allSlots];

        for (int j = 0; j < allSlots; j++)
        {
            slot[j]=slotHolder.transform.GetChild(j).gameObject;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryEnable  = !inventoryEnable;
        }

        if (inventoryEnable == true)
        {
            inventory1.SetActive(true);
        }
        else
        {
            inventory1.SetActive(false);
        }
    }
}
