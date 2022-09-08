using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : RaycastController
{
    public Vector3 move;
    public override void Start()
    {
        base.Start();
    }
    private void Update()
    {
        Vector3 velocity = move * Time.deltaTime;
        transform.Translate(velocity);
    }

}
