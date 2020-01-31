using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter)), RequireComponent(typeof(MeshRenderer)),RequireComponent(typeof(MeshCollider))]
public class Planet : MonoBehaviour
{
    public int subdivisions = 2;
    public Material material;
    private PlanetMesh planetMesh;

    private MeshRenderer meshRenderer;
    private MeshFilter meshFilter;
    private MeshCollider meshCollider;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshFilter = GetComponent<MeshFilter>();
        meshCollider = GetComponent<MeshCollider>();
    }

    [ContextMenu("CreateMesh")]
    public void CreateMesh()
    {
#if UNITY_EDITOR
        meshRenderer = GetComponent<MeshRenderer>();
        meshFilter = GetComponent<MeshFilter>();
        meshCollider = GetComponent<MeshCollider>();
#endif
        meshRenderer.material = material;
        PlanetMesh planetMesh = new PlanetMesh(subdivisions);
        meshFilter.mesh = planetMesh.GenerateMesh();
    }
}