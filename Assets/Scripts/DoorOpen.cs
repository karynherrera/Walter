using UnityEngine;
using UnityEngine.EventSystems;

public class DoorOpen : MonoBehaviour
{
    public AudioSource doorisopen;
    void Start()
    {
        doorisopen = GetComponent<AudioSource>();
    }
    void Update()
    {

    }

    public void OnTriggerEnter2D()
    {
        if (doorisopen != null && doorisopen.clip != null)
        {
            doorisopen.Play();
            Destroy(gameObject, doorisopen.clip.length);
        }

    }

}
