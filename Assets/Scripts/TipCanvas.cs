using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipCanvas : MonoBehaviour
{
    public Transform Target;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animation>().Play("Hide");
    }
    public void Show()
    {
        GetComponent<Animation>().Play("Show");
    }
    public void Hide()
    {
        GetComponent<Animation>().Play("Hide");
    }
    // Update is called once per frame
    void Update()
    {
        var dir = transform.position - Target.position;
        
        dir.Normalize();
        transform.rotation = Quaternion.FromToRotation(Vector3.forward, dir);
        
    }
}
