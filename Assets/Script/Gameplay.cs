using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray,out hit))
            {
                if(hit.collider.gameObject.name.CompareTo("RedSphere") == 0)
                {
                    hit.collider.gameObject.SetActive(false);
                }
            }
        }
    }
}
