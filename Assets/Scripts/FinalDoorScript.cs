using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoorScript : MonoBehaviour
{
    public int leveramount;

    public Transform LDoor;
    public Transform RDoor;

    public Transform RDoorPOS;
    public Transform LDoorPOS;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (leveramount == 4)
        {
            LDoor.position = Vector3.Lerp(transform.localPosition, LDoorPOS.position, 1);
            RDoor.position = Vector3.Lerp(transform.localPosition, RDoorPOS.position, 1);
        }

    }
}
