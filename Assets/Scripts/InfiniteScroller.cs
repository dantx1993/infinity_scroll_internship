using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class LayoutData
{
    public float top;
    public float bottom;
    public float spacing;
}

public class InfiniteScroller : MonoBehaviour
{
    [SerializeField] private ScrollRect _scroll;
    [SerializeField] private Item _itemPrefab;

    [SerializeField] private LayoutData _layoutData;

    private float _itemsHeight = -1;

    private void SetData(int numberOfData = 100)
    {
        Rect rect = _scroll.GetComponent<RectTransform>().rect;
        rect.size = new Vector2(rect.width, CalculateHeight(_layoutData, ))
    }
    private float CalculateHeight(LayoutData layoutData, float itemsHeight, int numberOfData)
    {
        return layoutData.top + layoutData.bottom + numberOfData * itemsHeight + (numberOfData - 1) * itemsHeight;
    }
    private float GetItemsHeight()
    {
        if(_itemsHeight < 0)
        {
            _itemsHeight = _itemPrefab.GetComponent<RectTransform>().rect.height;
        }
        return _itemsHeight;
    }
}
