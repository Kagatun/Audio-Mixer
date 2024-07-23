using UnityEngine;
using UnityEngine.UI;

public class HealthBarCutting : HealthBar
{
    [SerializeField] private Slider _slider;

    private float _maxValue = 1f;

    private void Start()
    {
        _slider.maxValue = _maxValue;
        _slider.value = _maxValue;
    }

    public override void DrawHealth(int health, int maxHealth)
    {
        _slider.value = (float)health / maxHealth;
    }
}
