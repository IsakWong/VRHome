using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public Button BuyBtn;

    public GameObject BuyTarget1;
    public Transform BuyPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnBuyBtnClick()
    {
        var new_obj = GameObject.Instantiate(BuyTarget1);
        new_obj.transform.position = BuyPos.position;
        Debug.Log("123");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
