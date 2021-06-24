using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infiniteloop : MonoBehaviour
{
    Camera camra;
    float height,width,w;
    // Start is called before the first frame update
    void Start()
    {
        camra = Camera.main;
        height = 2f * camra.orthographicSize;
         w = GetComponent<SpriteRenderer>().bounds.size.x;
        width = height*camra.aspect;
    }

    // Update is called once per frame
    void Update()
    {

        if (camra.transform.position.x - width / 2 > transform.position.x + w / 2)
        {
            Vector3 position = transform.position;
            GameObject[] all = GameObject.FindGameObjectsWithTag(transform.gameObject.tag);
            float g = 0;
            for(int i = 0; i < all.Length; i++)
            {
                if (g < all[i].transform.position.x) g = all[i].transform.position.x;
            }
             position.x= g + w;
            transform.position = position;
        }
    }
}
