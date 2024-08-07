using UnityEngine;
using UnityEngine.UI;

public class Healing : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Health _health;

    private int _healing = 15;

    private void OnEnable()
    {
        if (_health != null)
        {
            _button.onClick.AddListener(OnButtonClick);
        }
    }

    private void OnDisable()
    {
        if (_health != null)
        {
            _button.onClick.RemoveListener(OnButtonClick);
        }
    }

    private void OnButtonClick()
    {
        _health.ReplenishHealth(_healing);
    }
}
