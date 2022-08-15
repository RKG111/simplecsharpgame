using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject StartGame;
    public GameObject Endgame;

    void Start()
    {
        StartGame.SetActive(true);
        Endgame.SetActive(false);
        Time.timeScale=0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void start(){
        Time.timeScale=1;
        StartGame.SetActive(false);

    }

    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void exit(){
        Application.Quit();
    }
}
