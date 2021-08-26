using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    public Transform Target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        var dir = Target.rotation * new Vector3(0, 0, 1.5f);
        transform.position = Target.position + dir;
    }
}
