using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingDoorbell : MonoBehaviour
{

    public GameObject DoorbellText;
    public AudioSource Doorbell;
    bool OnTrigger;
    public GameObject bar;
    public float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        DoorbellText.SetActive(false);
        time = Time.time;
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
                time = Time.time;
                Destroy(this);
                DoorbellText.SetActive(false);

                if (time + 2 <= Time.time)
                {
                    bar.SetActive(true);
                    time = Time.time;
                }
            }
        }
        else 
        {
            DoorbellText.SetActive(false);
        }
    }
}
