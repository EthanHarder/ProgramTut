using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField]
    public float currentTime { get; private set; }

    [field: SerializeField]
    public float maxTime { get; set; }

    [SerializeField]
    private Text timerText;

    private void Awake()
    {
        currentTime = maxTime;
    }

    private void LateUpdate()
    {
        currentTime -= Time.deltaTime;
        timerText.text = "Time: " + Mathf.Floor(currentTime);
    }

    public void externalUpdateTime(float nT)
    {
        currentTime = nT;
    }
}
