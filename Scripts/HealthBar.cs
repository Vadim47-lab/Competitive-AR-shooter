using UnityEngine.UI;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _trackablePlayer;
    [SerializeField] private Slider _slider;

    private void OnEnable()
    {
        _trackablePlayer.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _trackablePlayer.HealthChanged -= OnHealthChanged;
    }

    private void Start()
    {
        _slider.maxValue = _trackablePlayer.Health;
        _slider.value = _trackablePlayer.Health;
    }

    private void OnHealthChanged(int health)
    {
        _slider.value = health;
    }
}