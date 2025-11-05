using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GAMEMANAGER : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject PausemenuUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void gameOver()
    {
        gameOverUI.SetActive(true);

    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("restartGame");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("MainMenu");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QuitGame");
    }
    public void startGame()
    {
        SceneManager.LoadScene("GAMEPLAYSCENE");
        Debug.Log("startGame");
    }
    public void control()
    {
        SceneManager.LoadScene("controls");
        Debug.Log("control");
    }
    public void pauseGame()
    {
        PausemenuUI.SetActive(true);
        Time.timeScale = 0;
    }
    public void resumeGame()
    {
        PausemenuUI.SetActive(false);
        Time.timeScale = 1;
    }
    public void backtoMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
        Debug.Log("backtoMainMenu");
    }
}
