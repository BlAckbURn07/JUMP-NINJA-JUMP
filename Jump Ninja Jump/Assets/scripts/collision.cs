using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    GameObject charc;
    [SerializeField]
    GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        charc = transform.gameObject;
        
    }



    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "box")
        {
            Destroy(charc);
            Instantiate(menu);
        }   
    }
}
