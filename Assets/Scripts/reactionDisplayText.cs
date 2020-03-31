using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class reactionDisplayText : MonoBehaviour, IPointerClickHandler
{

    public void OnPointerClick(PointerEventData eventData)
    {

        Debug.Log(this.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text);
        
    }
}
