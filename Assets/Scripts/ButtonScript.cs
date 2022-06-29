using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
/*    void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 100.0f) && Input.GetMouseButtonDown(0))
        {
            if (hit.transform != null && hit.transform == this.gameObject)
            {
                PrintName(hit.transform.gameObject);
            }
        }
    }

    void PrintName(GameObject go)
    {
        points += 1;
        print(go.name);
    }

    public double points = 0;
}