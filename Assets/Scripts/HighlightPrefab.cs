using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightPrefab : MonoBehaviour
{
    public List<GameObject> objectsToHighlight;
    public Material highlightMaterial;

    private List<Renderer> objectRenderers = new List<Renderer>();
    private List<Material> originalMaterials = new List<Material>();

    void Start()
    {
        foreach (GameObject obj in objectsToHighlight)
        {
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null)
            {
                objectRenderers.Add(renderer);
                originalMaterials.Add(renderer.material);
            }
        }
    }

    public void OnButtonClick()
    {
        Highlight();
    }

    void Highlight()
    {
        for (int i = 0; i < objectRenderers.Count; i++)
        {
            if (objectRenderers[i] != null && highlightMaterial != null)
            {
                objectRenderers[i].material = highlightMaterial;
            }
        }
    }

    void Unhighlight()
    {
        for (int i = 0; i < objectRenderers.Count; i++)
        {
            if (objectRenderers[i] != null && originalMaterials[i] != null)
            {
                objectRenderers[i].material = originalMaterials[i];
            }
        }
    }

    void OnDisable()
    {
        Unhighlight();
    }
}