using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sec : MonoBehaviour
{
    [SerializeField] private string selectableTag = "puzzleArea";

    private Transform _selection;

    void Update()
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<SpriteRenderer>();
            selectionRenderer.color = new Color (0,0,0,255);
            _selection = null;
        }
        
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))    
        {
            Debug.Log("MouseButtonDown");
            if (Physics.Raycast(ray, out hit))
            {
                var selection = hit.transform;
                if (selection.CompareTag(selectableTag))
                {
                    var selectionRenderer = selection.GetComponent<SpriteRenderer>();
                    if (selectionRenderer != null)
                    {
                        selectionRenderer.color = new Color (159,159,159,255);
                    }
    
                    _selection = selection;
                }
            }
        }
    }

}
