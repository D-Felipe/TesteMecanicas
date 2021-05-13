using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
[SerializeField] string nomeCena;

    public void changeS()
    {
        SceneManager.LoadScene(nomeCena);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
