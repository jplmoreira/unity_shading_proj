using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class GameStatus : MonoBehaviour
{

    public int maxHealth;
    public int maxCrystals;
    public Text textCrystals;
    public Transform healthImages;
    public Transform gameOver;
    public Transform mainMenu;
    public GameObject player;
    public GameObject startScreen;
    public GameObject finalScreen;
    public Text crystalText;
    public Text time;

    private int health, crystals;
    private float timePassed;

    // Start is called before the first frame update
    void Start()
    {

        player.GetComponent<FirstPersonController>().LockCursor();
        Time.timeScale = 0;
        Cursor.visible = true;

        startScreen.SetActive(true);
        
        health = maxHealth;
        crystals = maxCrystals;
        timePassed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
            GameOver();

        timePassed += Time.deltaTime;
    }

    public void updateCrystals()
    {
        crystals--;
        textCrystals.text = (maxCrystals - crystals) + "/" + maxCrystals;
    }

    public void damage()
    {
        health--;
        if (healthImages.childCount > 0)
            Object.Destroy(healthImages.GetChild(healthImages.childCount - 1).gameObject);
    }

    public void GameOver()
    {
        player.GetComponent<FirstPersonController>().LockCursor();
        Time.timeScale = 0;
        gameOver.gameObject.SetActive(true);
        Cursor.visible = true;
    }

    public void MainMenu() {
        SceneManager.LoadScene("Teste");
    }

    public void StartGame()
    {
        startScreen.SetActive(false);

        player.GetComponent<FirstPersonController>().UnlockCursor();
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Teste");
        startScreen.SetActive(false);
        player.GetComponent<FirstPersonController>().UnlockCursor();
        Time.timeScale = 1;
    }

    public void EndGame()
    {
        player.GetComponent<FirstPersonController>().LockCursor();
        Time.timeScale = 0;
        Cursor.visible = true;
        finalScreen.SetActive(true);
        crystalText.text = "Crystals: " + (maxCrystals - crystals);
        time.text = "Time: " + timePassed.ToString("N") + " s";
    }
}
