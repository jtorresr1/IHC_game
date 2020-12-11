using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory2 : MonoBehaviour
{
  private bool inventoryEnable;
    public GameObject inventory;

    private int allSlots;

    private int enableSlot;

    private GameObject[] slot;

    public GameObject slotHolder;
    // Start is called before the first frame update
    void Start()
    {
        allSlots = slotHolder.transform.childCount;
        slot = new GameObject[allSlots];

        for (int i = 0; i < allSlots; i++)
        {
            slot[i]=slotHolder.transform.GetChild(i).gameObject;
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
            inventory.SetActive(true);
        }
        else
        {
            inventory.SetActive(false);
        }
    }
}