using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingDoorbell : MonoBehaviour
{

    public GameObject DoorbellText;
    public AudioSource Doorbell;
    bool OnTrigger;

    // Start is called before the first frame update
    void Start()
    {
        DoorbellText.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            OnTrigger = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            OnTrigger = false;

        }
    }

    private void Update()
    {
        if (OnTrigger)
        {
            DoorbellText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                Doorbell.Play();
                Destroy(this);
            }
        }
        else 
        {
            DoorbellText.SetActive(false);
        }
    }

}
