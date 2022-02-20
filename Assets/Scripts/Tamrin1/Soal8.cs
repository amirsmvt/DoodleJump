using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soal8 : MonoBehaviour
{
    // Start is called before the first frame update
    public float Average;
    public long Multiply1=1;
    public long Multiply2=1;

    void Start()
    {
        for(int i =1;i<=150;i++ )
        {
            Average += i;
        }
        Average /= 150;
        for(int i =1;i<=15;i++ )
        {
            if (i <= 10)
                Multiply1 *= i;
            Multiply2 *= i;
        }
        print($"Average is{Average} & multiply from 1 to 10 is :{Multiply1} & multiply from 1 to 15 is :{Multiply2}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
