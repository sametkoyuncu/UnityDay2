using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenkDegistir : MonoBehaviour
{
    public Color[] renkler;
    public Material yolMalzemesi;
    int renkSecimi;
    // Start is called before the first frame update
    void Start()
    {
        renkSecimi = Random.Range(0, 3);
        yolMalzemesi.color = renkler[renkSecimi];
    }

    // Update is called once per frame
    void Update()
    {
        //gün 10 2:00:00 ile 2:10:00 civarý, deðiþen renk
    }
}
