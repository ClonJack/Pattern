using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class Hadler : MonoBehaviour
{
    [SerializeField] private List <UnityEvent> commands;


    private void Update()
    {

        for (int i = 0; i < commands.Count; i++)
        {
            if (commands[i] != null)
                commands[i].Invoke();
        }
    }





}


