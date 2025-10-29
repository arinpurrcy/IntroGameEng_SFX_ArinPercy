using UnityEngine;

public class AudioPause : MonoBehaviour
{
    AudioSource source;
    BoxCollider soundTrigger;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<BoxCollider>();
    }

    void OnTriggerEnter(BoxCollider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            source.Play();
        }
    }
}