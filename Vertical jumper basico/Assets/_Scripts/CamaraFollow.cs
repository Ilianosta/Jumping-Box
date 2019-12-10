using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    public Transform character;
    Vector3 posCam;
    private void Start()
    {
        posCam = this.transform.position;
    }
    private void FixedUpdate()
    {
        posCam.y = character.position.y + 3.8f;
        if(posCam.y > this.transform.position.y)
        {
            this.transform.position = posCam;
        }
        
    }
}
