using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour
{

    // Start is called before the first frame update

    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level3");

    }

    public void Level4()
    {
        SceneManager.LoadScene("Level4");

    }
    public void HighScore()
    {
        SceneManager.LoadScene("HighScore");
    }

    public void oneplayer()
    {
        SceneManager.LoadScene("1player");

    }

    public void options()
    {
        SceneManager.LoadScene("options");
    }

    public void femalee()
    {
        SceneManager.LoadScene("female");

    }

    public void malee()
    {
        SceneManager.LoadScene("Male");
    }
    public void choseMFf()
    {
        SceneManager.LoadScene("ChoseMF");
    }
}