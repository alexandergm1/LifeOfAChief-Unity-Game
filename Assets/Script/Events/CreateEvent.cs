using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CreateEvent : MonoBehaviour
{

    [SerializeField] private Transform EventPopup;
    [SerializeField] private Transform panel;
    [SerializeField] private Transform EventLocation;


    void Start(){
        EventManager.EventPopup += generateEvent;
        
    }

    void generateEvent(){
        GameEvent currentEvent = GameEventList.Instance.events[0];
        Instantiate(EventPopup, EventLocation.position, Quaternion.identity, panel.transform);
        Text eventTitle = GameObject.Find("Event Title").GetComponent<Text>();
        Text eventText = GameObject.Find("Event Text").GetComponent<Text>();
        Text option1Text = GameObject.Find("Option1 Text").GetComponent<Text>();
        Text option2Text = GameObject.Find("Option2 Text").GetComponent<Text>();
        Text option3Text = GameObject.Find("Option3 Text").GetComponent<Text>();
        Button Option1 = GameObject.Find("Option1").GetComponent<Button>();
		Option1.onClick.AddListener(event1method1);

        eventTitle.text = currentEvent.title;
        eventText.text = currentEvent.content;
        option1Text.text = currentEvent.option1;
        option2Text.text = currentEvent.option2;
        option3Text.text = currentEvent.option3;

    }

    public void event1method1(){
        Player.Instance.Gold -= 50;
        Player.Instance.Lumber -= 50;
    }
    public void event1method2(){
        Player.Instance.Gold -= 25;
        Player.Instance.Lumber -= 25;
    }
    public void event1method3(){
        Player.Instance.Gold -= 0;
    }
}