using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [System.Serializable]
    public class Gear
    {
        public GameObject gear;
        public float direction;
        public float speed;
    }

    public Gear[] rotations;
    private int i;

    void Update()
    {
        for(i = 0; i < rotations.Length; i++)
        {
            if(rotations[i].gear != null)
            {
                rotations[i].gear.transform.Rotate(0, 0, rotations[i].direction * rotations[i].speed * Time.deltaTime);
            }
        }
    }
}
