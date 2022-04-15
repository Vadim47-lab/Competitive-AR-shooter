using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class MenuGame : MonoBehaviour
{
    [SerializeField] private UnityEvent _buttonPress;
    [SerializeField] private GameObject _menu;
    [SerializeField] private Button _continueButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private Button _returnMainMenuButton;
    [SerializeField] private Button _escMenuButton;

    private void OnEnable()
    {
        _continueButton.onClick.AddListener(OnContinueButtonClick);
        _exitButton.onClick.AddListener(OnExitButtonClick);
        _returnMainMenuButton.onClick.AddListener(OnReturnMainMenuClick);
        _escMenuButton.onClick.AddListener(OnEscMenuClick);
    }

    private void OnDisable()
    {
        _continueButton.onClick.RemoveListener(OnContinueButtonClick);
        _exitButton.onClick.RemoveListener(OnExitButtonClick);
        _returnMainMenuButton.onClick.RemoveListener(OnReturnMainMenuClick);
        _escMenuButton.onClick.RemoveListener(OnEscMenuClick);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0;
            _menu.SetActive(true);
        }
    }

    private void OnContinueButtonClick()
    {
        EventButtonPress();

        Time.timeScale = 1;
        _menu.SetActive(false);
    }

    private void OnExitButtonClick()
    {
        EventButtonPress();

        Application.Quit();
    }

    private void OnReturnMainMenuClick()
    {
        EventButtonPress();

        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void OnEscMenuClick()
    {
        EventButtonPress();
        _menu.SetActive(true);
        Time.timeScale = 0;
    }

    private void EventButtonPress()
    {
        _buttonPress?.Invoke();
    }
}