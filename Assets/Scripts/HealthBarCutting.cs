using UnityEngine;
using UnityEngine.UI;

public class HealthBarCutting : HealthBar
{
    [SerializeField] private Slider _slider;

    public override void DrawMaxHealth(int health)
    {
        _slider.maxValue = health;
        _slider.value = health;
    }

    public override void DrawHealth(int health)
    {
        _slider.value = health;
    }
}
