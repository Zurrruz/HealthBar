using UnityEngine;
using UnityEngine.UI;

public abstract class ButtonParameters : MonoBehaviour
{
    [SerializeField] protected Health HealthCharacter;
    [SerializeField] protected int Value;
    [SerializeField] protected Button Button;

    private void OnEnable()
    {
        Button.onClick.AddListener(Press);
    }

    private void OnDisable()
    {
        Button.onClick.RemoveListener(Press);
    }

    public abstract void Press();
}
