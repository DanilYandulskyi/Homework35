using UnityEngine;
using TMPro;

public class UITextHealth : MonoBehaviour
{
    [SerializeField] private Health _health;

    private TextMeshProUGUI _text;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();

        _health.OnHealthChange += UpdateText;
    }

    private void OnDestroy()
    {
        _health.OnHealthChange -= UpdateText;
    }

    private void UpdateText()
    {
        _text.text = $"{_health.CurrentValue} / {_health.MaxValue}";
    }
}
