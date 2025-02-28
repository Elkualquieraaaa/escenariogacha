using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.AI.Navigation;

public class Navmeshscript : MonoBehaviour
{
    private NavMeshSurface nav;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        nav = GetComponent<NavMeshSurface>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Refreshmesh();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            nav.RemoveData();
        }
    }

    public void Refreshmesh()
    {
        nav.BuildNavMesh();
    }
}
