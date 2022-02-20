using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject doodle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < doodle.transform.position.y)
        {
            Vector3 pos = new Vector3(transform.position.x, doodle.transform.position.y, transform.position.z);
            transform.position = pos;
        }
    }
}
