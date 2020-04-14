using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitComponent : Command
{
    [SerializeField] private Camera camera;
    [SerializeField] private float lengthRay;
    [SerializeField] private float maxLengthRay;
    [SerializeField] private Color colorRay;

    private void Start()
    {
        camera = Camera.main;
    }

    private void Hit(Hadler actor)
    {

    

        RaycastHit raycast;

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray,out raycast, maxLengthRay))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
                Debug.Log(raycast.collider.name);

      

        }

        Debug.DrawRay(ray.origin, ray.direction * lengthRay , colorRay);
    }

    public override void Execute(Hadler actor)
    {
        Hit(actor);
    }
}
