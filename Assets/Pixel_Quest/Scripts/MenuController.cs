using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string nextLevel= "Level1";
    public void LoadLevel()
    {
        SceneManager.LoadScene(nextLevel);
}
    public void QuitGame()
    {
        Application.Quit();
}








}
