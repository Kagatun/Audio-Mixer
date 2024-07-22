using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private float _smoothSpeed = 30f;
    private float _targetHealth;

    private void Start()
    {
        _targetHealth = _slider.value;
    }

    private void FixedUpdate()
    {
        _slider.value = _slider.value = Mathf.MoveTowards(_slider.value, _targetHealth, _smoothSpeed * Time.deltaTime);
    }

    public void DrawMaxHealth(float health)
    {
        _slider.maxValue = health;
        _slider.value = health;
        _targetHealth = health;
    }

    public void DrawHealth(float health)
    {
        _targetHealth = health;
    }
}
