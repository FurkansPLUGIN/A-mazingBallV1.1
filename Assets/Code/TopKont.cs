using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopKont : MonoBehaviour
{
    Rigidbody rigid;
    public int hız = 5;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");
        Vector3 vec3 = new Vector3(yatay, 0, dikey);
        rigid.AddForce(vec3 * hız);
    }
    void OnTriggerEnter(Collider other)
    {
        string isim = other.gameObject.tag;
        if (isim=="engel")
        {
            Destroy(other.gameObject);
        }
       
    }
    void OnCollisionEnter(Collision collision)
    {
        string isim = collision.gameObject.tag;
        if (isim == "duvar")
        {
            Debug.Log("gg");
        }
    }
}
