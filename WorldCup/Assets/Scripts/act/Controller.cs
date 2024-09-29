using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public bool isGameStarted = false;
    public int index = 0;
    public string selectedcategoryName = null;
    public int selectedRound = 0;
    public bool isRight = false;
    public bool isClick = false;

    void Update()
    {
        if (!isGameStarted && App.inst.uiMgr.openingMgr.IsShow())
        {
            HandleGameStart();
        }

        if (isGameStarted)
        {
            if (App.inst.uiMgr.categoryMgr.IsShow())
                HandleCategorySelection();

            if (App.inst.uiMgr.roundMgr.IsShow())
                HandleRoundSelection();

            if (App.inst.uiMgr.matchTableMgr.IsShow())
                HandleMatchTableSelection();

            if (App.inst.uiMgr.resultMgr.IsShow())
                HandleResultSelection();
        }
    }

    void HandleGameStart()
    {
        if (Input.GetKeyDown(KeyCode.A))
            GameStart();
    }

    void HandleCategorySelection()
    {
        HandleSelection(KeyCode.RightArrow, KeyCode.LeftArrow, App.inst.uiMgr.categoryMgr.categoryList.Count, (newIndex) =>
        {
            App.inst.uiMgr.categoryMgr.SelectedItem(newIndex);
            App.inst.uiMgr.matchTableMgr.categoryIndex = newIndex;
            selectedcategoryName = App.inst.uiMgr.categoryMgr.categoryList[newIndex].name;
            ScrollToSelected(App.inst.uiMgr.categoryMgr.categoryList[newIndex].gameObject, App.inst.uiMgr.categoryMgr.rect);
        });

        if (Input.GetKeyDown(KeyCode.Return))
        {
            App.inst.uiMgr.categoryMgr.Hide(() =>
            {
                index = 0;
                App.inst.uiMgr.roundMgr.Show();
            });
        }
    }

    void HandleRoundSelection()
    {
        HandleSelection(KeyCode.RightArrow, KeyCode.LeftArrow, App.inst.uiMgr.roundMgr.roundList.Count, (newIndex) =>
        {
            App.inst.uiMgr.roundMgr.SelectedItem(newIndex);
            App.inst.uiMgr.matchTableMgr.RoundIndex = newIndex;
            selectedRound = App.inst.uiMgr.roundMgr.roundList[newIndex].round;
        });

        if (Input.GetKeyDown(KeyCode.Return))
        {
            App.inst.uiMgr.roundMgr.Hide(() =>
            {
                index = 0;
                App.inst.uiMgr.matchTableMgr.Show();
            });
        }
    }

    void HandleMatchTableSelection()
    {
        HandleSelection(KeyCode.RightArrow, KeyCode.LeftArrow, App.inst.uiMgr.matchTableMgr.matchList.Count, (newIndex) =>
        {
            App.inst.uiMgr.matchTableMgr.SelectedItem(newIndex);
            isRight = (newIndex == 1);
        });

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (!isRight)
                App.inst.uiMgr.matchTableMgr.SelectLeft();
            else
                App.inst.uiMgr.matchTableMgr.SelectRight();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            App.inst.uiMgr.matchTableMgr.Hide(() =>
            {
                App.inst.uiMgr.matchTableMgr.Reset();
                App.inst.uiMgr.roundMgr.Show();
            });
        }
    }

    void HandleResultSelection()
    {
        HandleSelection(KeyCode.RightArrow, KeyCode.LeftArrow, App.inst.uiMgr.resultMgr.btnImg.Length, (newIndex) =>
        {
            App.inst.uiMgr.resultMgr.btnImg[0].color = (newIndex == 0) ? Color.yellow : Color.white;
            App.inst.uiMgr.resultMgr.btnImg[1].color = (newIndex == 1) ? Color.yellow : Color.white;
            isClick = (newIndex == 1);
        });

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (!isClick)
            {
                App.inst.uiMgr.resultMgr.Hide(() =>
                {
                    App.inst.uiMgr.roundMgr.Show();
                    
                });
            }
            else
            {
                App.inst.uiMgr.resultMgr.Hide(() =>
                {
                    
                    App.inst.uiMgr.categoryMgr.Show();
                });
            }
            App.inst.uiMgr.resultMgr.isChecked = true;
        }
    }
    
    void HandleSelection(KeyCode rightKey, KeyCode leftKey, int itemCount, System.Action<int> onItemSelected)
    {
        if (Input.GetKeyDown(rightKey))
        {
            index = (index + 1) % itemCount;
            onItemSelected(index);
        }
        else if (Input.GetKeyDown(leftKey))
        {
            index = (index - 1 + itemCount) % itemCount;
            onItemSelected(index);
        }
    }

    public void GameStart()
    {
        isGameStarted = true;
        App.inst.uiMgr.openingMgr.Hide(() =>
        {
            App.inst.uiMgr.categoryMgr.Show();
        });
    }

    void ScrollToSelected(GameObject selectedItem, ScrollRect rect)
    {
        RectTransform selectedRectTransform = selectedItem.GetComponent<RectTransform>();
        RectTransform contentRectTransform = rect.content;

        float contentWidth = contentRectTransform.rect.width;
        float itemPositionX = selectedRectTransform.localPosition.x;
        float itemWidth = selectedRectTransform.rect.width;

        float targetX = (itemPositionX + (itemWidth / 2)) / contentWidth;

        float scrollViewWidth = rect.viewport.rect.width;
        float centerOffset = (scrollViewWidth / 2 / contentWidth) * 0.05f;

        if (index == 0)
        {
            rect.horizontalNormalizedPosition = 0f;
        }
        else if (index == App.inst.uiMgr.categoryMgr.categoryList.Count - 1)
        {
            rect.horizontalNormalizedPosition = 1f;
        }
        else
        {
            rect.horizontalNormalizedPosition = Mathf.Clamp01(targetX - centerOffset);
        }
    }
}
