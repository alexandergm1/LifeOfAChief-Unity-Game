using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class EventManager : MonoBehaviour
{

    public static event Action EventPopup;
    public GameObject endTurnButton;


    void Update()
    {
        if (EventSystem.current.currentSelectedGameObject == endTurnButton)
        {
            EventPopup?.Invoke();
            EventSystem.current.GetComponent<EventSystem>().SetSelectedGameObject(null);
        }
    }
}