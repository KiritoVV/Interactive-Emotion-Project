using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KeySystem
{
    public class KeyItemController : MonoBehaviour
    {
        [SerializeField] private bool greyDoor = false;
        [SerializeField] private bool greykey = false;

        [SerializeField] private KeyInventory _KeyInventory = null;

        private KeyDoorController doorObject;

        private void Start()
        {
            if (greyDoor)
            doorObject = GetComponent<KeyDoorController>();
        }

        private void objectInteraction()
        {
            if (greyDoor)
            {
                doorObject.PlayAnimation();
            }

            else if (greyDoor)
            {
                _KeyInventory.hasGreyKey = true;
                gameObject.SetActive(false);
            }
        }
        
    }
}
