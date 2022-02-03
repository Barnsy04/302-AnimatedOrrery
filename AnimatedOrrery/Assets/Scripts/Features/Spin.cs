using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float spinSpeed = 100f;
    public float tilt = 50f;

    private void Start()
    {
        transform.Rotate(tilt, 0f, 0f);
    }
    void Update()
    {
        transform.Rotate(0f, spinSpeed * Time.deltaTime, 0f, Space.Self);
    }
}
