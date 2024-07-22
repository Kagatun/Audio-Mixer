using UnityEngine;
using UnityEngine.UI;

public class Attacker : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        if (_player != null)
        {
            _button.onClick.AddListener(_player.TakeDamage);
        }
    }

    private void OnDisable()
    {
        if (_player != null)
        {
            _button.onClick.RemoveListener(_player.TakeDamage);
        }
    }
}
