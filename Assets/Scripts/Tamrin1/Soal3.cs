using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soal3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("This is Start!");
        
    }
    private void Awake()
    {
        print("This is awake!");
    }
    // Update is called once per frame
    void Update()
    {
        print("This is Update!");
    }
    private void OnEnable()
    {
        print("This is onEnable!");
    }
    private void OnDestroy()
    {
        print("This is OnDestroy!");
    }
    private void FixedUpdate()
    {
        print("This is FixedUpdate!");
        
    }
    private void OnDisable()
    {
        print("This is onDisable!");
        Destroy(this.gameObject);
    }
}
