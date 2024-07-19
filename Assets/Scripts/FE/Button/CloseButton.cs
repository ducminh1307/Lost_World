using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : BaseButton
{
    protected override void OnButtonClick()
    {
        base.OnButtonClick();

        UIManager.Instance.GetPanel(UIPanelType.Tab).Hide();
    }
}
