using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeyItemController : MonoBehaviour
{
    [SerializeField] private bool greyDoor = false;
    [SerializeField] private bool greyKey = false;

    [SerializeField] private  KeyInventory1 _KeyInventory1 = null;

    private KeyDoorController doorObject;

    private void Start()
    {
       if (greyDoor)
        {
            doorObject = GetComponent<KeyDoorController>();

        }

    }

    public void ObjectInteraction()
    {
        if (greyDoor)
        {
            doorObject.PlayAnimation();
        }

        else if (greyKey)
        {
            _KeyInventory1.hasGreyKey = true;
            gameObject.SetActive(false);
        }
            
           
    }
}
