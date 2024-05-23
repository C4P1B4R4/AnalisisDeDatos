using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Analytics;
using UnityEngine.UI;
public class Analytics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnityServices.InitializeAsync();
        AnalyticsService.Instance.StartDataCollection();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        Application.Quit();
        Debug.Log("Salio");
    }

 
}
