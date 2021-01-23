using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionManager : MonoBehaviour
{

    public Material highlightMaterial;
    public Material defaultMaterial;

    public float totalTime = 2f;
    float gazeTimer;

    public Image imgGaze;

    private Transform _selection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();

            imgGaze.GetComponent<Image>().color = new Color32(0, 0, 255, 255);

            imgGaze.fillAmount = 1f;

            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;

            var selectionRenderer = selection.GetComponent<Renderer>();

            if (selectionRenderer != null)
            {
                imgGaze.GetComponent<Image>().color = new Color32(255, 0, 0, 255);

                gazeTimer += Time.deltaTime;

                imgGaze.fillAmount = gazeTimer / totalTime;

                if (gazeTimer >= totalTime)
                {
                    selectionRenderer.material = highlightMaterial;
                    selection.gameObject.tag = "Dummy_M";
                }
            }

            _selection = selection;
        }
        else
        {
            gazeTimer = 0f;
            imgGaze.fillAmount = 1f;
        }
    }
}
