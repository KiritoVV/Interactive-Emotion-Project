using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tp : MonoBehaviour
{
    public Transform Destination;
    public Transform Player;

    public CharacterController pc;
    public bool CutsceneActive = false;
    public bool LogoRotate = false;

    public GameObject Cutscene;
    public Transform Logo;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(Teleporter());
            StartCoroutine(CutSceneActivate());
        }
    }

    IEnumerator Teleporter()
    {
        pc.enabled = false;
        CutsceneActive = true;
        Player.position = new Vector3(Destination.position.x, Destination.position.y, Destination.position.z);
        yield return new WaitForSeconds(3);
        pc.enabled = true;
    }

    IEnumerator CutSceneActivate()
    {
        if(CutsceneActive == true)
        {
            Cutscene.gameObject.SetActive(true);
            LogoRotate = true;
            yield return new WaitForSeconds(5);
            LogoRotate = false;
            Cutscene.gameObject.SetActive(false);
            CutsceneActive = false;
        }
    }
    private void Update()
    {
        if(LogoRotate == true)
        {
            Logo.localRotation = Quaternion.Euler(0, 0, Time.time * 100f);
        }
    }
}