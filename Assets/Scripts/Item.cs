using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    [Space, Header("UI")]
    [SerializeField] private Image _imgBG;
    [SerializeField] private Text _txtIndex;
    [Space, Header("Data")]
    [SerializeField] private Color _evenColor;
    [SerializeField] private Color _oddColor;

    public void SetData(int index)
    {
        
    }
}
