using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : BaseButton
{
    protected override void OnButtonClick()
    {
        base.OnButtonClick();
        BasePanel parentPanel = GetComponentInParent<BasePanel>();

        parentPanel.Hide();
    }
}
