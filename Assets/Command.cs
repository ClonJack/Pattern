using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command : MonoBehaviour
{
    public virtual void Execute(Hadler actor)
    {
        Debug.LogException(new System.Exception("you don't add compnent in event for object:" + actor.name.ToString()));
    }

}
