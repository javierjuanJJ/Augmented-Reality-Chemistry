using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BondInteraction : MonoBehaviour
{
    [SerializeField] private GameObject element1, element2;

    [SerializeField] private AppManagerGame AppManager;
    [SerializeField] private float Distance;
    [SerializeField] private GameObject bondObject;
    
    void Update()
    {
        if (AppManager.ElementIsActivated(element1.name) && AppManager.ElementIsActivated(element2.name) && (Vector3.Distance(element1.transform.position, element2.transform.position) < Distance))
        {
            bondObject.SetActive(true);
            bondObject.transform.position = (element1.transform.position + element2.transform.position) / 2;
            
            element1.SetActive(false);
            element2.SetActive(false);
        }
        else
        {
            bondObject.SetActive(false);
            element1.SetActive(true);
            element2.SetActive(true);
        }
    }
}
