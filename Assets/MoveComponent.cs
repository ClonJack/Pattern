using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveComponent : Command
{
    [SerializeField] private KeyCode[] keyCodeXAxsis = new KeyCode[2];
    [SerializeField] private KeyCode[] keyCodeZAxsis = new KeyCode[2];



    private void Move(Hadler actor)
    {

        if (Input.GetKey(keyCodeXAxsis[0]))
            actor.transform.Translate(Vector3.left);

        if (Input.GetKey(keyCodeXAxsis[1]))
            actor.transform.Translate(Vector3.right);

        if (Input.GetKey(keyCodeZAxsis[0]))
            actor.transform.Translate(Vector3.forward);

        if (Input.GetKey(keyCodeZAxsis[1]))
            actor.transform.Translate(Vector3.back);
    }

    public override void Execute(Hadler actor)
    {
        Move(actor);
    }
}
