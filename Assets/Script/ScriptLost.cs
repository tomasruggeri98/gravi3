using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptLost : MonoBehaviour
{
    public float tiempoEspera = 5f;

    void Start()
    {
        // Iniciar la cuenta regresiva para cambiar a la siguiente escena
        Invoke("CargarNivel1", tiempoEspera);
    }

    void CargarNivel1()
    {
        // Cargar la escena del Nivel1
        SceneManager.LoadScene("SampleScene");
    }
}