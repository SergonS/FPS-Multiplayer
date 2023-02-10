using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    // Add or remove an Interaction Event component to this gameobject
    public bool useEvents;
    // Message displayed to the player when looking at interactable
    public string promptMessage;

    public virtual string OnLook()
    {
        return promptMessage;
    }
    
    // Function will be called from player
    public void BaseInteract()
    {
        if (useEvents)
        {
            GetComponent<InteractionEvent>().OnInteract.Invoke();
        }
        Interact();
    }

    protected virtual void Interact()
    {

    }
}
