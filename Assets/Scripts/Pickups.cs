using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Pickups : MonoBehaviour
{
    #region Variables
    [SerializeField] private GameObject glassShield;
    [SerializeField] private bool gs_Hit;
    #endregion
    private void Update()
    {

    }

    private void OnCollisionEnter(Collision morph)
    {
        #region Glass_Shield
        if (morph.gameObject.tag == "GS")
        {
            gs_Hit = true;
            Destroy(glassShield);
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    #endregion
}
