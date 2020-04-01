using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Interactions : MonoBehaviour, IPointerClickHandler
{

    [SerializeField] int numberOfInteractions;
    [SerializeField] string[] interactionNames;
    [SerializeField] GameObject interactionButton;

    bool isMenuOpen = false;
    GameObject tempObject;
    GameObject[] interactions;

    void Start()
    {
        interactions = new GameObject[interactionNames.Length];
        for (int i = 0; i < interactionNames.Length; i++)
        {
            Debug.Log("One shiny muffin");
            interactions[i] = Instantiate(interactionButton, GetComponent<Transform>().position,  Quaternion.identity, this.transform);
            interactions[i].SetActive(false);
            interactions[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = interactionNames[i];
        }
    }

    // Update is called once per frame
    public void OnPointerClick(PointerEventData eventData)
    {
        if (!isMenuOpen)
        {
            isMenuOpen = true;
            Debug.Log(isMenuOpen);
            for (int i = 0; i < interactions.Length; i++)
            {
                interactions[i].SetActive(true);
            }
        }
        else
        {
            isMenuOpen = false;
            Debug.Log(isMenuOpen);
            for (int i = 0; i < interactions.Length; i++)
            {
                interactions[i].SetActive(false);
            }
        }
    }

    public Vector3 GetPosition()
    {
        return this.transform.position;
    }


}
