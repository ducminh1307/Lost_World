using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PageSwiper : MonoBehaviour, IDragHandler, IEndDragHandler
{
    [SerializeField] private RectTransform contentTab;
    [SerializeField] private float widthChildren;
    float difference;

    private void Start()
    {
    }

    public void OnDrag(PointerEventData eventData)
    {
        difference = eventData.pressPosition.x - eventData.position.x;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        float newPosition = 0;
        float currentPosX = contentTab.anchoredPosition.x;

        // Luot tu phai sang trai
        if (difference > 0)
        {
            //Neu den item cuoi cung thi dung
            if (widthChildren >= (contentTab.rect.width - Mathf.Abs(currentPosX)))
                return;
            newPosition = currentPosX - widthChildren;
        }
        
        //Luot tu trai sang phai
        if (difference < 0)
        {
            //Neu den item dau tien thi dung
            if (contentTab.anchoredPosition.x == 0)
                return;
            newPosition = currentPosX + widthChildren;
        }

        contentTab.DOAnchorPosX(newPosition, .15f);
    }
}
