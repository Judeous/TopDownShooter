﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehavior : MonoBehaviour
{
    [SerializeField] private HealthBehaviour _health;
    [SerializeField] private Slider _slider;
    [SerializeField] private Gradient _healthGradient;
    [SerializeField] private Image _fill;

    // Start is called before the first frame update
    void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = _health.Health;
        _fill.color = _healthGradient.Evaluate(1f);
    }

    // Update is called once per frame
    void Update()
    {
        _slider.value = _health.Health;
        _fill.color = _healthGradient.Evaluate(_slider.value / _slider.maxValue);
    }
}
