using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TabPanel : BasePanel
{
    [Header("Elements")]
    [SerializeField] private RectTransform rect;
    [SerializeField] private RectTransform tabContainer;

    [Header("Properties")]
    [SerializeField] private float duration = .1f;
    [SerializeField] private Ease effect;

    protected override void Awake()
    {
        base.Awake();

        UIManager.Instance.ResgisterPanel(UIPanelType.Tab, this);
        canvasGroup = GetComponent<CanvasGroup>();

        rect.localScale = new Vector3(.1f, .1f, .1f);
    }

    public override void Hide()
    {
        base.Hide();
        canvasGroup.DOFade(0, duration);
        rect.DOScale(new Vector3(.1f, .1f, .1f), duration)
            .SetEase(effect)
            .OnComplete(() =>
            {
                Deactive();
            });
    }

    public override void Show()
    {
        base.Show();
        canvasGroup.DOFade(1, duration);
        rect.DOScale(Vector3.one, duration)
            .SetEase(effect);
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
