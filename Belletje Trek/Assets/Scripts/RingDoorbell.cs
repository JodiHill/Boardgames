using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingDoorbell : MonoBehaviour
{

    public GameObject DoorbellText;
    public AudioSource Doorbell;

    // Start is called before the first frame update
    void Start()
    {
        DoorbellText.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            DoorbellText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                Doorbell.Play();
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        DoorbellText.SetActive(false);
    }

}
