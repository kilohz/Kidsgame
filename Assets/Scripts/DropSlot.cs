using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.XR.WSA.Input;

public class DropSlot : MonoBehaviour, IDropHandler
{

    [SerializeField] private Sprite State1;
    [SerializeField] private Sprite State2;
    [SerializeField] private Sprite State3;
    private int State = 0;

    [SerializeField] public string ValidItemTag = "";

    [SerializeField] public GameObject Particles;



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
        if (eventData.pointerDrag != null && eventData.pointerDrag.gameObject.tag == ValidItemTag)
        {
            State++;
            Destroy(eventData.pointerDrag.gameObject);
            //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

            UpdateSprite();

            //showEffects
            StartCoroutine(ShowParticleEffects());
        }
    }

    private IEnumerator ShowParticleEffects()
    {
        var effects = this.Particles.GetComponent<ParticleSystem>();
        //if (!effects.isPlaying)
        //{
            effects.Play();
            yield return new WaitForSeconds(0.5f);
            effects.Stop();
        //}
    }

    private void UpdateSprite()
    {
        Sprite sprite = null;
        switch (State)
        { 
            case 0:
                sprite = State1;
            break;
            case 1:
                sprite = State2;
                break;
            case 2:
                sprite = State3;
                break;
            default:
                sprite = State1;
                break;
        }
        this.GetComponent<Image>().sprite = sprite;
    }
}
