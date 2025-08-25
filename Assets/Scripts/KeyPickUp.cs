using UnityEngine;
using UnityEngine.EventSystems;

public class KeyPickUp : MonoBehaviour
{
    public ExitDoor doorcontroller;
    public AudioSource clickpickup;

    void Start()
    {
        clickpickup = GetComponent<AudioSource>();
    }

    void Update()
    {

    }

    void OnMouseDown()
    {
        if (clickpickup != null && clickpickup.clip != null)
        {
            clickpickup.Play();
            doorcontroller.PickedUpObjects();
            Destroy(gameObject, clickpickup.clip.length);
        }
    }

}

