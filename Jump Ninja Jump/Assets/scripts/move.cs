using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.x = position.x + 5 * Time.deltaTime;
        transform.position = position;
    }
}
