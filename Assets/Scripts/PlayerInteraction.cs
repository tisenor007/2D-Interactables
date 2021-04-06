using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject currentInterObj = null;
    public ObjectInteraction currentObjectInteractionScript;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && currentInterObj == true)
        {
            if (currentObjectInteractionScript.pickup == true)
            {
                currentObjectInteractionScript.PickUp();
            }
            if (currentObjectInteractionScript.info == true)
            {
                currentObjectInteractionScript.Info();
            }
            if (currentObjectInteractionScript.talks == true)
            {
                currentObjectInteractionScript.Dialogue();
            }


        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("InterObject") == true)
        {
            currentInterObj = other.gameObject;
            currentObjectInteractionScript = currentInterObj.GetComponent<ObjectInteraction>();
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("InterObject") == true)
        {
            currentInterObj = null;
        }
    }
}
