using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter)), RequireComponent(typeof(MeshRenderer))]
public class MeshTest1 : MonoBehaviour
{
    int[] Triangles;
    Vector3[] Vertices;
    Vector3[] Normals;
    private MeshFilter meshFilter;
    private MeshRenderer meshRenderer;
    private Mesh mesh;

    void Awake(){
        meshFilter = GetComponent<MeshFilter>();
        meshRenderer = GetComponent<MeshRenderer>();
    }
    void Start()
    {
        // Vertices = new Vector3[]{
        //     new Vector3( 1, 0,  1),
        //     new Vector3(-1, 0,  1),
        //     new Vector3(-1, 0, -1),
        //     new Vector3( 1, 0, -1)
        // };

        // Triangles = new int[]{
        //     0,3,2,
        //     0,2,1
        // };
        // Normals = new Vector3[]{
        //     new Vector3(0,1,0),
        //     new Vector3(0,1,0),
        //     new Vector3(0,1,0),
        //     new Vector3(0,1,0)
        // };

        // if(!mesh)
        //     mesh = new Mesh();
        // else
        //     mesh.Clear();

        // mesh.SetVertices(Vertices);
        // mesh.triangles = Triangles;
        // mesh.normals = Normals;
        // mesh.colors = new Color[]{
        //     Random.ColorHSV(),
        //     Random.ColorHSV(),
        //     Random.ColorHSV(),
        //     Random.ColorHSV()
        // };

        // meshFilter.mesh = mesh;

    }

    float speed = 100.0f;

    // Update is called once per frame
    void Update()
    {
        // obtain the normals from the Mesh
        Vector3[] normals = mesh.normals;

        // edit the normals in an external array
        Quaternion rotation = Quaternion.AngleAxis(Time.deltaTime * speed, Vector3.up);
        for (int i = 0; i < normals.Length; i++)
            normals[i] = rotation * normals[i];

        // assign the array of normals to the mesh
        mesh.normals = normals;
    }
}
