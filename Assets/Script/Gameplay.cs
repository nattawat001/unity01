using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gameplay : MonoBehaviour
{
 int g = 20,r = -20, b = 10 ,sum = 0;
 public TextMeshProUGUI txtDisplay;
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
                    sum = sum + r;
                }
                if(hit.collider.gameObject.name.CompareTo("Red01") == 0)
                {
                    hit.collider.gameObject.SetActive(false);
                    sum = sum + r;
                }
                if(hit.collider.gameObject.name.CompareTo("Red02") == 0)
                {
                    hit.collider.gameObject.SetActive(false);
                    sum = sum + r;
                }
                if(hit.collider.gameObject.name.CompareTo("Red03") == 0)
                {
                    hit.collider.gameObject.SetActive(false);
                    sum = sum + r;
                }
                 if(hit.collider.gameObject.name.CompareTo("BlueSphere") == 0)
                {
                    hit.collider.gameObject.SetActive(false);
                    sum = sum + b;
                    
                }
                 if(hit.collider.gameObject.name.CompareTo("Blue01") == 0)
                {
                    hit.collider.gameObject.SetActive(false);
                    sum = sum + b;
                    
                }
                 if(hit.collider.gameObject.name.CompareTo("Blue02") == 0)
                {
                    hit.collider.gameObject.SetActive(false);
                    sum = sum + b;
                    
                }

                if(hit.collider.gameObject.name.CompareTo("GreenSphere") == 0)
                {
                    hit.collider.gameObject.SetActive(false);
                    sum = sum + g;
                    
                }
                if(hit.collider.gameObject.name.CompareTo("Green01") == 0)
                {
                    hit.collider.gameObject.SetActive(false);
                    sum = sum + g;
                    
                }
                if(hit.collider.gameObject.name.CompareTo("Green02") == 0)
                {
                    hit.collider.gameObject.SetActive(false);
                    sum = sum + g;
                    
                }
                Debug.Log(sum);
                txtDisplay.text ="POINT" + sum;
            }
        }
    }
}
