using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakipciKamera : MonoBehaviour
{
    public Transform takipEdilen;
    public Vector3 mesafe;
    // Start is called before the first frame update
    void Start()
    {
        mesafe = transform.position - takipEdilen.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        if(TopHaraket.topDustu == true)
        {
            return;
        }
        transform.position = takipEdilen.position + mesafe;
    }
}
