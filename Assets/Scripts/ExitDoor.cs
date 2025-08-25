using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitDoor : MonoBehaviour
{
    public int itopickup = 4;
    public int ipickedup = 0;
    public GameObject Pista;

    public void Final()
    {
        SceneManager.LoadScene("Fin");
    }


    public void PickedUpObjects()
    {
        ipickedup = ipickedup + 1;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (ipickedup >= itopickup)
            {
                Final();
            }
            else
            {
                Pista.SetActive(true);
                Invoke("PistaHide", 2f);

            }
        }
    }

    void PistaHide()
    {
        if (Pista != null)
        {
            Pista.SetActive (false);
        }
    }

}
