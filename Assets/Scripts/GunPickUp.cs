using UnityEngine;
using UnityEngine.EventSystems;

public class GunPickUp : MonoBehaviour
{
    public ExitDoor doorcontroller;
    public AudioSource clickpickup;
    void Start()
    {
        clickpickup = GetComponent<AudioSource>();
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
