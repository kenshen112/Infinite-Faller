using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    // Start is called before the first frame update
    int worth;
    void Start()
    {
       worth = 2; 
    }

    Collectable Collect()
    {
        return this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
