using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, ISelectHandler
{
    public void OnSelect(BaseEventData eventData){
        Debug.Log(this.gameObject.name + " was selected");
    }

}
