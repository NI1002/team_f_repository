using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassButtonCS : MonoBehaviour
{
    private GameObject targetcontroller;
    // Start is called before the first frame update
    void Start()
    {
        targetcontroller = GameObject.Find("TargetControll");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        Debug.Log("PassBottonOnclick()");
        targetcontroller.GetComponent<TargetController>().ChangeTarget();
    }
}
