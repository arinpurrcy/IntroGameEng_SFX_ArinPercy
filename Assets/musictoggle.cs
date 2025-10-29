using UnityEngine;

public class musictoggle : MonoBehaviour
{
    public AudioSource playSound;

    private void OnTriggerEnter(Collider other)
    {
        playSound.Pause();
    }
    private void OnTriggerExit(Collider other)
    {
        playSound.Play();
    }
}