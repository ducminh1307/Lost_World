using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabContainerButton : BaseButton
{
    protected override void OnButtonClick()
    {
        base.OnButtonClick();

        UIManager.Instance.GetPanel(UIPanelType.TabButton).Hide();
    }
}
