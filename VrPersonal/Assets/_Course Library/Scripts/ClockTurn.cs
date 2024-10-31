using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockTurn : MonoBehaviour
{

    public float rotateSpeed;
    public GameObject secHand;
    public GameObject minHand;
    public GameObject hourHand;

    // Start is called before the first frame update
    void Start()
    {
        rotateSpeed = Time.deltaTime / 60;
    }

    // Update is called once per frame
    void Update()
    {
        secHand.transform.Rotate(0, 0, rotateSpeed, Space.World);
        minHand.transform.Rotate(0,  0, rotateSpeed /60, Space.World);
        hourHand.transform.Rotate(0, 0, rotateSpeed / 12, Space.World);
    }
}
