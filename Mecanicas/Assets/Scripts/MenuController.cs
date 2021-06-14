using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
[SerializeField] string nomeCena;
    public void changeS()
    {
        Time.timeScale =1f;
        SceneManager.LoadScene(nomeCena);
    }
    public void Quit()
    {
        Application.Quit();
    }

}
