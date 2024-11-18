using UnityEngine;
using UnityEngine.UI;

public abstract class ButtonParameters : MonoBehaviour
{
    [SerializeField] protected Health HealthCharacter;
    [SerializeField] protected int Value;
    [SerializeField] protected Button Button;

    private void Awake()
    {
        Button.onClick.AddListener(Press);
    }
    
    public abstract void Press();
}
