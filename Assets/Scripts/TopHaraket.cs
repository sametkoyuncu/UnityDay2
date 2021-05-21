using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopHaraket : MonoBehaviour
{
    Vector3 yon;
    public float hiz;
    public YolOlustur yolOlustur;
    public static bool topDustu;
    public Text skorTxt;
    int skorInt=0;
    public Text enYuksekSkorTxt;
    int enYuksekSkorInt;
    // Start is called before the first frame update
    void Start()
    {
        yon = Vector3.left;
        topDustu = false;
        enYuksekSkorInt = PlayerPrefs.GetInt("enYuksekSkorPref");
        enYuksekSkorTxt.text = enYuksekSkorInt.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(topDustu == true)
        {
            return;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(yon.x==0)
            {
                yon = Vector3.left;
            }
            else
            {
                yon = Vector3.back;
            }
        }

        if(transform.position.y < -1f)
        {
            topDustu = true;
            Destroy(this.gameObject);
            if(enYuksekSkorInt<skorInt)
            {
                enYuksekSkorInt = skorInt;
                PlayerPrefs.SetInt("enYuksekSkorPref", enYuksekSkorInt);
            }
        }
    }

    void FixedUpdate()
    {
        if(skorInt>0 && (skorInt%10)==0)
        {
            hiz += 0.01f;
        }
        Vector3 topGit = yon * Time.deltaTime * hiz;
        transform.position += topGit;
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Yolum")
        {
            StartCoroutine(YokEt(collision.gameObject));
            yolOlustur.YolOlusturucu();
            skorInt++;
            skorTxt.text = skorInt.ToString();
        }
    }

    IEnumerator YokEt(GameObject yokEdilecekYol)
    {
        yield return new WaitForSeconds(0.5f);
        yokEdilecekYol.AddComponent<Rigidbody>();
        yield return new WaitForSeconds(1.5f);

        Destroy(yokEdilecekYol);
    }
}
