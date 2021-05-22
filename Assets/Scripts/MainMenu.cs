using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Easy1()
    {
        SceneManager.LoadScene("Easy 1");
    }
    public void Easy2()
    {
        SceneManager.LoadScene("Easy 2");
    }
    public void Easy3()
    {
        SceneManager.LoadScene("Easy 3");
    }
    public void Normal1()
    {
        SceneManager.LoadScene("Normal 1");
    }
    public void Normal2()
    {
        SceneManager.LoadScene("Normal 2");
    }
    public void Normal3()
    {
        SceneManager.LoadScene("Normal 3");
    }
    public void Hard1()
    {
        SceneManager.LoadScene("Hard 1");
    }
    public void Hard2()
    {
        SceneManager.LoadScene("Hard 2");
    }
    public void Hard3()
    {
        SceneManager.LoadScene("Hard 3");
    }
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
