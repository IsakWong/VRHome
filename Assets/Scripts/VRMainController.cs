using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRMainController : MonoBehaviour
{
    public GameObject BuyMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.One))
        {
            BuyMenu.GetComponent<Animator>().SetBool("Show", true);
        }
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            BuyMenu.GetComponent<Animator>().SetBool("Show", false);
        }

    }
}
