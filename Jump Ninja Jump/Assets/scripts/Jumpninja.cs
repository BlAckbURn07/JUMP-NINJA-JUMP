using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpninja : MonoBehaviour
{
    [SerializeField]
    GameObject glider;
    [SerializeField]
    GameObject jumper;

    Rigidbody2D player;
    GameObject charc;

    // Update is called once per frame
    void Update()
    {
        charc = transform.gameObject;
        player = GetComponent<Rigidbody2D>();
        if (Input.GetMouseButtonDown(0))
        {
            player.velocity = new Vector3(0, 5, 0);
        }
        if (player.velocity.y > 0)
        {
            if (charc.tag != "jump")
            {
                Vector3 position = transform.position;
                Rigidbody2D rb = GetComponent<Rigidbody2D>();
                Vector3 speed = rb.velocity;
                Destroy(charc);
                charc = Instantiate(jumper, position, Quaternion.identity);
                rb = charc.GetComponent<Rigidbody2D>();
                rb.velocity = speed;
            }
        }
        else
        {
            if (charc.tag != "glide")
            {
                Vector3 position = transform.position;
                Rigidbody2D rb = GetComponent<Rigidbody2D>();
                Vector3 speed = rb.velocity;
                Destroy(charc);
                charc = Instantiate(glider, position, Quaternion.identity);
                rb = charc.GetComponent<Rigidbody2D>();
                rb.velocity = speed;
            }
        }
    }
}
