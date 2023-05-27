using UnityEngine;

public class DoorbellTrigger : MonoBehaviour
{
    [SerializeField] private string interactMessage = "Press E to Ring the Doorbell";
    [SerializeField] private AudioClip doorbellSound;
    [SerializeField] private GameObject opponent;

    private bool hasTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;
            Debug.Log(interactMessage);
            AudioSource.PlayClipAtPoint(doorbellSound, transform.position);
            opponent.SetActive(true);
        }
    }
}
