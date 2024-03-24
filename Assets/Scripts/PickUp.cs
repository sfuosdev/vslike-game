using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "pickup")
        {
            switch (col.gameObject.name)
            {
                case "HealthPack":
                    // increase health
                    break;
            }
            col.gameObject.SetActive(false);
        }
    }
}
