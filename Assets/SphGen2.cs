using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphGen2 : MonoBehaviour
{
    
    [SerializeField] Vector3 sphereSize;
    // Start is called before the first frame update
    void Start()
    {
        
        //spherePoz = MazeGenerator.GetComponent<MazeGenerator> .getCorner();
        GameObject otherObject = GameObject.Find("Maze Generator");
        MazeGenerator mazga =  otherObject.GetComponent<MazeGenerator>();
        Vector3 spherePoz = mazga.getCorner();
        // Generate a new sphere at the specified position
        GameObject sphere = SphereScript.CreateSphere(spherePoz, sphereSize);
        sphere.tag = "Player";

 
    }


}
