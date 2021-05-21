using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YolOlustur : MonoBehaviour
{
    public GameObject sonYol;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            YolOlusturucu();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("aa");
    }
    
    //
    // Kamera ile oynadýðým için 'forward', eðitim videosunda sol alt þeklinde olurken, bende sað alt þeklinde ilerliyor
    // 'right' sol üst,
    // 'left' sol alt (videodaki 'forward')
    // 'back' sað üst
    public void YolOlusturucu()
    {
        Vector3 yon;
        Random.Range(0, 2);
        if(Random.Range(0,2) == 0)
        {
            yon = Vector3.back;
        }
        else
        {
            yon = Vector3.left;
        }
        sonYol = Instantiate(sonYol, sonYol.transform.position + yon, sonYol.transform.rotation);
    }
}
