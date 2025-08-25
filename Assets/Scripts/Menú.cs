using UnityEngine;
using UnityEngine.SceneManagement;

public class Menú : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Juego");
    }

    public void Salir()
    {
        Application.Quit();
    }

}
