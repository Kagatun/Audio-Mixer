using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSmooth : HealthBar
{
    [SerializeField] private Slider _slider;

    private Coroutine _coroutineSmoothChange;
    private float _smoothTime = 0.5f;
    private float _maxValue = 1f;

    private void Start()
    {
        _slider.maxValue = _maxValue;
        _slider.value = _maxValue;
    }

    public override void DrawHealth(int health, int maxHealth)
    {
        if (_coroutineSmoothChange != null)
        {
            StopCoroutine(_coroutineSmoothChange);
        }

        float targetValue = (float)health / maxHealth;
        _coroutineSmoothChange = StartCoroutine(SmoothHealthChange(targetValue));
    }

    private IEnumerator SmoothHealthChange(float targetValue)
    {
        float startValue = _slider.value;
        float elapsedTime = 0f;

        while (_slider.value != targetValue)
        {
            _slider.value = Mathf.MoveTowards(startValue, targetValue, elapsedTime / _smoothTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        _slider.value = targetValue;
    }
}
