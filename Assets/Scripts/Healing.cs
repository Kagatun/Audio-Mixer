using UnityEngine;
using UnityEngine.UI;

public class Healing : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        if (_player != null)
        {
            _button.onClick.AddListener(_player.ReplenishHealth);
        }
    }

    private void OnDisable()
    {
        if (_player != null)
        {
            _button.onClick.RemoveListener(_player.ReplenishHealth);
        }
    }
}
