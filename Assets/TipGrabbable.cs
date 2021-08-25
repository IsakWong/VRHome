using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipGrabbable : OVRGrabbable
{
    // Start is called before the first frame update
    public override void GrabBegin(OVRGrabber hand, Collider grabPoint) 
    {
        base.GrabBegin(hand, grabPoint);
        GetComponentInChildren<TipCanvas>().Show();
    }

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);
        GetComponentInChildren<TipCanvas>().Hide();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
