using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject audioholder;
    public GameObject healthbar;
    public GameObject crosshair;
    public  GameObject canvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canvas.gameObject.SetActive(true);
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
        audioholder.SetActive(true);
        healthbar.SetActive(true);
        crosshair.SetActive(true);
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PausePanel.activeSelf)
            {
                audioholder.SetActive(true);
                healthbar.SetActive(true);
                crosshair.SetActive(true);
                Resume();

            }
            else
            {
                audioholder.SetActive(false);
                healthbar.SetActive(false);
                crosshair.SetActive(false);
                Pause();
            }
        }
    }

    public void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
