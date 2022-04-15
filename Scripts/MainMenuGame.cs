using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuGame : MonoBehaviour
{
    [SerializeField] private UnityEvent _buttonPress;
    [SerializeField] private GameObject _help;
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private Button _openHelpButton;
    [SerializeField] private Button _closeHelpButton;

    private void OnEnable()
    {
        _startButton.onClick.AddListener(OnStartButtonClick);
        _exitButton.onClick.AddListener(OnExitButtonClick);
        _openHelpButton.onClick.AddListener(OnOpenHelpButtonClick);
        _closeHelpButton.onClick.AddListener(OnCloseHelpButtonClick);
    }

    private void OnDisable()
    {
        _startButton.onClick.RemoveListener(OnStartButtonClick);
        _exitButton.onClick.RemoveListener(OnExitButtonClick);
        _openHelpButton.onClick.RemoveListener(OnOpenHelpButtonClick);
        _closeHelpButton.onClick.RemoveListener(OnCloseHelpButtonClick);
    }

    private void OnStartButtonClick()
    {
        EventButtonPress();

        SceneManager.LoadScene(1);
    }

    private void OnExitButtonClick()
    {
        EventButtonPress();

        Application.Quit();
    }

    private void OnOpenHelpButtonClick()
    {
        EventButtonPress();

        _help.SetActive(true);
    }

    private void OnCloseHelpButtonClick()
    {
        EventButtonPress();

        _help.SetActive(false);
    }


    private void EventButtonPress()
    {
        _buttonPress?.Invoke();
    }
}