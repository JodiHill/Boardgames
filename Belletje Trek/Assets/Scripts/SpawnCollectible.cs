using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCollectible : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnCollectible;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(spawnCollectible, new Vector3(12.212f, -0.234f, 12.133f), Quaternion.identity);
        }
        
    }
}
