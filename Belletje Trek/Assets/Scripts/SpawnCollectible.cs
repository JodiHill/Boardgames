using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCollectible : MonoBehaviour

{

    public float Timer = 8;
    bool Activated = false;
    bool OnTrigger;

    [SerializeField]
    private GameObject spawnCollectible;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    // TO DO: Doorbell, OnTriggerStay

    void Update()
    {
        if (Timer <= 0)
        {
            Instantiate(spawnCollectible, new Vector3(12.212f, -0.234f, 12.133f), Quaternion.identity);
            Destroy(this);
        }
        if (Activated == true)
        {
            Timer -= Time.deltaTime;
        }
        if (OnTrigger == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Activated = true;
            }
        }

    }

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
}
