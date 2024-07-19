using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabPanel : BasePanel
{
    private void Awake()
    {
        UIManager.Instance.ResgisterPanel(UIPanelType.Tab, this);
    }

    public override void Hide()
    {
        base.Hide();
    }

    public override void Show()
    {
        base.Show();
    }
}
