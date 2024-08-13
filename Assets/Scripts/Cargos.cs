using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Cargos : MonoBehaviour 
{
       public GameObject hoverObject; // O objeto que você quer mostrar/ocultar

    void Start()
    {
        if (hoverObject != null)
        {
            hoverObject.SetActive(false); // Certifique-se de que o objeto está inicialmente oculto
        }

        EventTrigger trigger = gameObject.AddComponent<EventTrigger>();

        // PointerEnter
        EventTrigger.Entry entryEnter = new EventTrigger.Entry();
        entryEnter.eventID = EventTriggerType.PointerEnter;
        entryEnter.callback.AddListener((eventData) => { OnPointerEnter((PointerEventData)eventData); });
        trigger.triggers.Add(entryEnter);

        // PointerExit
        EventTrigger.Entry entryExit = new EventTrigger.Entry();
        entryExit.eventID = EventTriggerType.PointerExit;
        entryExit.callback.AddListener((eventData) => { OnPointerExit((PointerEventData)eventData); });
        trigger.triggers.Add(entryExit);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse entrou no botão");
        if (hoverObject != null)
        {
            hoverObject.SetActive(true); // Mostra o objeto quando o mouse entra no botão
            Debug.Log("Objeto ativado");
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse saiu do botão");
        if (hoverObject != null)
        {
            hoverObject.SetActive(false); // Oculta o objeto quando o mouse sai do botão
            Debug.Log("Objeto desativado");
        }
    }
}
