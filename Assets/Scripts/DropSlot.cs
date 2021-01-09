using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlot : MonoBehaviour, IDropHandler
{
	[SerializeField]
	public Image state1;
	[SerializeField]
	public Image state2;
	[SerializeField]
	public Image state3;

	[SerializeField]
	public string ValidItemTag = "";

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


	public void OnDrop(PointerEventData eventData)
	{
		Debug.Log("OnDrop");
		if (eventData.pointerDrag != null)
		{
			//eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
		}
	}
}
