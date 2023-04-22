using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGenerator : MonoBehaviour
{   
    [SerializeField] List<Material> sphereMats;
    [SerializeField] GameObject spherePrefab;

    public static int sphereMatIndex = 0;

    void Start()
    {
        GameObject mazeGenGameObj = GameObject.Find("Maze Generator"); //alternativ se putea folosi static function
        MazeGenerator mazeGenObj = mazeGenGameObj.GetComponent<MazeGenerator>();
        Vector3 spherePoz = mazeGenObj.getCorner();

        GameObject Sphere = Instantiate(spherePrefab, spherePoz, Quaternion.identity, transform); // se creaza sfera 
        Sphere.GetComponent<Renderer>().material = sphereMats[sphereMatIndex]; // se selecteaza materialul
        Sphere.tag = "Player"; 
        
    }

}
