using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TabPanel : BasePanel
{
    [Header("Elements")]
    [SerializeField] private RectTransform containerTab;
    [SerializeField] private RectTransform tabContainer;
    PageSwiper swiper;

    [Header("Properties")]
    [SerializeField] private float duration = .1f;
    [SerializeField] private Ease fadeTtransition;

    protected override void Awake()
    {
        base.Awake();

        UIManager.Instance.ResgisterPanel(UIPanelType.Tab, this);
        canvasGroup = GetComponent<CanvasGroup>();
        swiper = GetComponentInChildren<PageSwiper>();

        containerTab.localScale = new Vector3(.1f, .1f, .1f);
    }

    public override void Hide()
    {
        base.Hide();
        canvasGroup.DOFade(0, duration);
        containerTab.DOScale(new Vector3(.1f, .1f, .1f), duration)
            .SetEase(fadeTtransition)
            .OnComplete(() =>
            {
                Deactive();
            });
    }

    public override void Show()
    {
        base.Show();
        canvasGroup.DOFade(1, duration);
        containerTab.DOScale(Vector3.one, duration)
            .SetEase(fadeTtransition);
    }

    public void ShowTab(UITab tabType)
    {
        switch (tabType)
        {
            case UITab.Setting:
                tabContainer.DOAnchorPosX(0, 0);
                break;

            case UITab.Process:
                tabContainer.DOAnchorPosX(-391, 0);
                break;

            case UITab.Effect:
                tabContainer.DOAnchorPosX(-782, 0);
                break;
        }
    }
}
