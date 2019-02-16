using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject wheelOne;
    public GameObject wheelTwo;
    public float speed;

    void Update()
    {
        wheelOne.transform.Rotate(0, 0, -1 * speed * Time.deltaTime);
        wheelTwo.transform.Rotate(0, 0, -1 * speed * Time.deltaTime);
    }
}
