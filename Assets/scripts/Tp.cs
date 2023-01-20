using UnityEngine;
using System.Collections;

public class Tp : MonoBehaviour
{
    public Transform Destination;
    public Transform Player;

    public CharacterController pc;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            pc.enabled = false;
            Player.position = new Vector3(Destination.position.x, Destination.position.y, Destination.position.z);
            Debug.Log("Collided");
            pc.enabled = true;
        }
    }
}