using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    // Method to create a new sphere game object with a Rigidbody component
    public static GameObject CreateSphere(Vector3 position, Vector3 size)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = position;
        sphere.transform.localScale = size;

        sphere.AddComponent<Rigidbody>(); // Add Rigidbody component to the sphere
        return sphere;
    }
}