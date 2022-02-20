using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelgenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public float MinX = -2.67f;
    public float MaxX = 2.69f;
    public int Count = 100;
    public float StartY;
    public float MinSpaceY, MaxSpaceY = 0f;
    public GameObject plat;

    void Start()
    {
        for(int i = 0; i<Count;i++)
        {
            GameObject platForm = Instantiate(plat);
            var x = 0f;
            if (i > 0)
                x = Random.Range(MinX, MaxX);
            var y = StartY;
            StartY += Random.Range(MinSpaceY,MaxSpaceY);
            platForm.transform.position = new Vector2(x, y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
