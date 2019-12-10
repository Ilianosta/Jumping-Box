using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject padre;
    private void Update()
    {
        if (this.CompareTag("Vacio"))
        {
            Destroy(this.gameObject);
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(padre);
    }
}
