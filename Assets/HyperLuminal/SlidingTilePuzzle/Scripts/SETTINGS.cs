using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SETTINGS : MonoBehaviour
{
    public GameObject picturePanel;

    public void OpenPanel()
    {
        picturePanel.SetActive(!picturePanel.activeSelf);
    }
}
