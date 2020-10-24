using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class JavaImplimentation : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void Complete();

    // Start is called before the first frame update
    void Start()
    {
        Complete();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
