using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;


public class MenuController : MonoBehaviour
{


    public GameObject startScreen;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StarGame()
    {
        Debug.Log("START GAME");
        SceneManager.LoadScene("Teste");
    }

    public void QuitGame()
    {

        Debug.Log("QUIT");
        Application.Quit();
    }

}

