using UnityEngine;
using TMPro;
public class timer : MonoBehaviour
{
    public GameObject gameOverUI;
    [SerializeField] TextMeshProUGUI timertext;
    float elaspedtime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elaspedtime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elaspedtime / 60);
        int seconds = Mathf.FloorToInt(elaspedtime % 60);
        timertext.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    public void resume()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0;
    }

}
