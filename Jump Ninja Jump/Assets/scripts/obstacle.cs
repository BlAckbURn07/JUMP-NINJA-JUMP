using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{

    [SerializeField]
    GameObject boxs;
    [SerializeField]
    GameObject box;
    [SerializeField]
    GameObject acid;

    float pos,h,hc,wc,w,ah;
    GameObject obs;
    void Start()
    {
        pos = 0;
        hc = 2f * Camera.main.orthographicSize;
        wc = hc * Camera.main.aspect;
        h = boxs.GetComponent<SpriteRenderer>().bounds.size.y;
        w = boxs.GetComponent<SpriteRenderer>().bounds.size.x;
        ah = acid.GetComponent<SpriteRenderer>().bounds.size.y;
    }

    // Update is called once per frame
    void Update()
    {


            if (transform.position.x + wc / 2 + w / 2 + 1 - pos >= 10)
            {
                int r = Random.Range(0, 2);
            if (r == 0)
            {
                float ad = Random.Range(0, w / 2);
                pos = transform.position.x + wc / 2 + w / 2 + 1;
                Vector3 position;
                position.x = pos;
                position.y = transform.position.y + hc / 2 - h / 2+ad;
                position.z = 0;
                obs = Instantiate(box);
                obs.transform.position = position;
            }
            else
            {
                float ad = Random.Range(0, ah / 2);
                pos = transform.position.x + wc / 2 + w / 2 + 1;
                Vector3 position;
                Quaternion rotation;
                rotation.x = 0;
                rotation.y = 0;
                rotation.z = 180;
                rotation.w = 0;
                position.x = pos;
                position.y = transform.position.y - hc / 2 + h / 2+ad;
                position.z = 0;
                obs = Instantiate(box);
                obs.transform.position = position;
                obs.transform.rotation = rotation;
            }
            }

        GameObject[] all = GameObject.FindGameObjectsWithTag("box");

        if (all[0].transform.position.x + w / 2 < transform.position.x - wc / 2)
        {
            Destroy(all[0]);
        }


    }
}
