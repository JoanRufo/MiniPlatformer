using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool playing = true;
    public Text m_textPuntuacion;
    public Text m_textVidas;
    [HideInInspector] public int m_Puntuacion;
    [HideInInspector] public int m_Vidas = 3;
    public GameObject m_GameOverPanel;
    public GameObject m_MenuPrincipal;
   
    void Start()
    {

    }

   
    void Update()
    {
        if (playing == true)
        {
<<<<<<< HEAD
           // m_textPuntuacion.text = "Puntos: " + m_Puntuacion;
=======
            //m_textPuntuacion.text = "Puntos: " + m_Puntuacion;
>>>>>>> efc9e0b00e41be39f3ea95669e4c93f5317d74d5
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        playing = true;

        m_MenuPrincipal.SetActive(false);

    }
    public void EndLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
