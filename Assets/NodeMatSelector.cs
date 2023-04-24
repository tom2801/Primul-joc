using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMatSelector: MonoBehaviour
{
    [SerializeField] List<Material> mazeNodeMats;   
    public static int mazeMatIndex =0;  

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material = mazeNodeMats[mazeMatIndex];
    }

    
}
