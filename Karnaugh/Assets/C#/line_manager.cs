using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line_manager : MonoBehaviour
{

    private LineRenderer[] lineRenderers;

    bool linlender_bool = true;

    // Start is called before the first frame update
    void Awake()
    {
        lineRenderers = FindObjectsOfType<LineRenderer>();
        
    }
    public void SetLineRenderersActive(bool isActive)
    {
        foreach (LineRenderer lineRenderer in lineRenderers)
        {
            lineRenderer.enabled = isActive;
        }
    }

    public void SetLineRenderer()
    {
        linlender_bool = !linlender_bool;
        foreach (LineRenderer lineRenderer in lineRenderers)
        {
            lineRenderer.enabled = linlender_bool;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
