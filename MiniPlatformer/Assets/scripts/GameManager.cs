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
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playing == true)
        {
            m_textPuntuacion.text = "Puntos: " + m_Puntuacion;
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
