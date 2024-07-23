using UnityEngine;
using UnityEngine.UI;

public class Attacker : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Health _health;

    private int _damage = 20;

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
        _health.TakeDamage(_damage);
    }
}
