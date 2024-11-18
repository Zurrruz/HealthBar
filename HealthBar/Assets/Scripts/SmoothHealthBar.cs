using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SmoothHealthBar : HealthBar
{
    private float _step = 0.5f;

    private Coroutine _coroutine;

    public override void Show()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(Change());
    }

    private IEnumerator Change()
    {
        while (Slider.value != Health.CurrentValue / Health.MaxValue)
        {
            Slider.value = Mathf.MoveTowards(Slider.value, Health.CurrentValue / Health.MaxValue, _step * Time.deltaTime);
            yield return null;
        }
    }
}