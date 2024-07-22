using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSmooth : HealthBar
{
    [SerializeField] private Slider _slider;

    private Coroutine _coroutineSmoothChange;
    private float _smoothSpeed = 200f;

    public override void DrawMaxHealth(int health)
    {
        _slider.maxValue = health;
        _slider.value = health;
    }

    public override void DrawHealth(int health)
    {
        if (_coroutineSmoothChange != null)
        {
            StopCoroutine(_coroutineSmoothChange);
        }

        _coroutineSmoothChange = StartCoroutine(SmoothHealthChange(health));
    }

    private IEnumerator SmoothHealthChange(float targetHealth)
    {
        while (_slider.value != targetHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, targetHealth, _smoothSpeed * Time.deltaTime);
            yield return null;
        }

        _slider.value = targetHealth;
    }
}
