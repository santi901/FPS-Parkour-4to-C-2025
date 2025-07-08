using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionarea : MonoBehaviour
{

    public GameObject interactionmessage;
    public MercanciaScript Mercancia;
    // Start is called before the first frame update
    void Start()
    {
        interactionmessage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Mercancia)
            {
               Mercancia.GetComponent<MercanciaScript>().onInteraction();
                StopInteraction();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        Mercancia = other.GetComponent<MercanciaScript>();
        if (Mercancia)
        {
            interactionmessage.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        StopInteraction();
    }

    void StopInteraction()
    {
        interactionmessage.SetActive(false);
        Mercancia = null;
    }
}
