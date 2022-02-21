using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyListener : MonoBehaviour
{
    GameObject cube;

    private Vector3 speed = new Vector3(0, 0, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.W)) speed = new Vector3(0, 0, 2);
        //else if (Input.GetKey(KeyCode.S)) speed = new Vector3(0, 0, -2);
        //else if (Input.GetKey(KeyCode.A)) speed = new Vector3(-2, 0, 0);
        //else if (Input.GetKey(KeyCode.D)) speed = new Vector3(2, 0, 0);
        //else speed = new Vector3(0, 0,0);
        //Debug.Log(speed);
        cube.gameObject.transform.Translate(Time.deltaTime * speed);
    }
    
    void OnMessageArrived(string msg)
    {
        // Debug.Log("moving at speed: " + msg);
        // float speed = float.Parse(msg) * 100;
        if (msg == "U" || Input.GetKey(KeyCode.W)) speed = new Vector3(0, 0, 3);
        else if (msg == "D" || Input.GetKey(KeyCode.S)) speed = new Vector3(0, 0, -3);
        else if (msg == "L" || Input.GetKey(KeyCode.A)) speed = new Vector3(-3, 0, 0);
        else if (msg == "R" || Input.GetKey(KeyCode.D)) speed = new Vector3(3, 0, 0);
        else speed = new Vector3(0, 0,0);
        
    }
    // Invoked when a connect/disconnect event occurs. The parameter 'success'
    // will be 'true' upon connection, and 'false' upon disconnection or
    // failure to connect.
    void OnConnectionEvent(bool success)
    {
        Debug.Log(success ? "Device connected" : "Device disconnected");
    }
}
