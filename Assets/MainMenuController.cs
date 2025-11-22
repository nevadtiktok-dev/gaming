using UnityEngine;
using UnityEngine.UI;

public class MainMenuAutoBinder : MonoBehaviour
{
    // Nazwy obiektów (możesz je zmienić tutaj, jeśli twoje nazwy różnią się)
    public string mainMenuName = "MainMenu";
    public string startButtonName = "START";
    public string creditsButtonName = "CREDITS";
    public string quitButtonName = "QUIT";

    private GameObject mainMenu;
    private Button startButton;
    private Button creditsButton;
    private Button quitButton;

    void Awake()
    {
        
        // Znajdź obiekty po nazwie w hierarchii sceny
        mainMenu = GameObject.Find(mainMenuName);
        if (mainMenu == null)
        {
            Debug.LogError($"[MainMenuAutoBinder] Nie znaleziono obiektu o nazwie '{mainMenuName}'. Sprawdź nazwę w Hierarchy.");
        }
        else
        {
            Debug.Log($"[MainMenuAutoBinder] Znaleziono MainMenu: {mainMenuName}");
        }

        // Znajdź przyciski — GameObject.Find -> GetComponent<Button>()
        var startObj = GameObject.Find(startButtonName);
        if (startObj == null) Debug.LogError($"[MainMenuAutoBinder] Nie znaleziono obiektu przycisku START ('{startButtonName}').");
        else startButton = startObj.GetComponent<Button>();

        var creditsObj = GameObject.Find(creditsButtonName);
        if (creditsObj == null) Debug.LogError($"[MainMenuAutoBinder] Nie znaleziono obiektu przycisku CREDITS ('{creditsButtonName}').");
        else creditsButton = creditsObj.GetComponent<Button>();

        var quitObj = GameObject.Find(quitButtonName);
        if (quitObj == null) Debug.LogError($"[MainMenuAutoBinder] Nie znaleziono obiektu przycisku QUIT ('{quitButtonName}').");
        else quitButton = quitObj.GetComponent<Button>();

        // Sprawdź czy komponenty Button są obecne
        if (startButton == null && startObj != null) Debug.LogError($"[MainMenuAutoBinder] Obiekt '{startButtonName}' nie ma komponentu Button.");
        if (creditsButton == null && creditsObj != null) Debug.LogError($"[MainMenuAutoBinder] Obiekt '{creditsButtonName}' nie ma komponentu Button.");
        if (quitButton == null && quitObj != null) Debug.LogError($"[MainMenuAutoBinder] Obiekt '{quitButtonName}' nie ma komponentu Button.");

        // Podłącz listener'y (tylko jeśli znaleziono komponenty)
        if (startButton != null)
        {
            startButton.onClick.RemoveAllListeners();
            startButton.onClick.AddListener(OnStartClicked);
            Debug.Log("[MainMenuAutoBinder] Podłączono listener do START.");
        }
        if (creditsButton != null)
        {
            creditsButton.onClick.RemoveAllListeners();
            creditsButton.onClick.AddListener(OnCreditsClicked);
            Debug.Log("[MainMenuAutoBinder] Podłączono listener do CREDITS.");
        }
        if (quitButton != null)
        {
            quitButton.onClick.RemoveAllListeners();
            quitButton.onClick.AddListener(OnQuitClicked);
            Debug.Log("[MainMenuAutoBinder] Podłączono listener do QUIT.");
        }
    }

    // Funkcje wywoływane przy kliknięciu
    private void OnStartClicked()
    {
        Debug.Log("[MainMenuAutoBinder] START kliknięty.");
        if (mainMenu != null)
        {
            mainMenu.SetActive(false);
            Debug.Log("[MainMenuAutoBinder] MainMenu ustawione na nieaktywne.");
        }
        else
        {
            Debug.LogError("[MainMenuAutoBinder] Nie mogę wyłączyć MainMenu — obiekt nie został znaleziony.");
        }
    }

    private void OnCreditsClicked()
    {
        Debug.Log("[MainMenuAutoBinder] CREDITS kliknięte. (nic więcej nie robi — dopisz akcję jeśli chcesz)");
        // Tu możesz dodać logikę pokazania creditsów
    }

    private void OnQuitClicked()
    {
        Debug.Log("[MainMenuAutoBinder] QUIT kliknięte. Wyłączanie aplikacji...");
        Application.Quit();

#if UNITY_EDITOR
        // W edytorze zatrzymuje tryb play (do testów)
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
