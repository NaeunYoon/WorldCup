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
            StartGame();
        }

        if (isGameStarted)
        {
            if (App.inst.uiMgr.categoryMgr.IsShow())
                CategorySelection();

            if (App.inst.uiMgr.roundMgr.IsShow())
                RoundSelection();
            
            if (App.inst.uiMgr.confirmMgr.IsShow())
                Confirmation();

            if (App.inst.uiMgr.matchTableMgr.IsShow())
                MatchTableSelection();

            if (App.inst.uiMgr.resultMgr.IsShow())
                ResultSelection();
        }
    }

    void StartGame()
    {
        if (Input.GetKeyDown(KeyCode.A))
            GameStart();
    }

    void CategorySelection()
    {
        Selection(KeyCode.RightArrow, KeyCode.LeftArrow, App.inst.uiMgr.categoryMgr.categoryList.Count, (newIndex) =>
        {
            App.inst.sfx.Play();
            App.inst.uiMgr.categoryMgr.SelectedItem(newIndex);
            App.inst.uiMgr.matchTableMgr.categoryIndex = newIndex;
            selectedcategoryName = App.inst.uiMgr.categoryMgr.categoryList[newIndex].name;
            ScrollToSelected(App.inst.uiMgr.categoryMgr.categoryList[newIndex].gameObject, App.inst.uiMgr.categoryMgr.rect);
        });

        if (Input.GetKeyDown(KeyCode.Return))
        {
            App.inst.sfx.Play();
            App.inst.uiMgr.categoryMgr.Hide(() =>
            {
                index = 0;
                App.inst.uiMgr.roundMgr.Show();
            });
        }
    }

    void RoundSelection()
    {
        Selection(KeyCode.RightArrow, KeyCode.LeftArrow, App.inst.uiMgr.roundMgr.roundList.Count, (newIndex) =>
        {
            App.inst.sfx.Play();
            App.inst.uiMgr.roundMgr.SelectedItem(newIndex);
            App.inst.uiMgr.matchTableMgr.RoundIndex = newIndex;
            selectedRound = App.inst.uiMgr.roundMgr.roundList[newIndex].round;
        });

        if (Input.GetKeyDown(KeyCode.Return))
        {
            App.inst.sfx.Play();
            App.inst.uiMgr.roundMgr.Hide(() =>
            {
                index = 0;
                App.inst.uiMgr.confirmMgr.Show();
            });
        }
    }

    void Confirmation()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            App.inst.sfx.Play();
            App.inst.uiMgr.confirmMgr.Hide(() =>
            {
                index = 0;
                App.inst.uiMgr.matchTableMgr.Show();
            });
        }
    }
    
    void MatchTableSelection()
    {
        Selection(KeyCode.RightArrow, KeyCode.LeftArrow, App.inst.uiMgr.matchTableMgr.matchList.Count, (newIndex) =>
        {
            App.inst.sfx.Play();
            App.inst.uiMgr.matchTableMgr.SelectedItem(newIndex);
            isRight = (newIndex == 1);
        });

        if (Input.GetKeyDown(KeyCode.Return))
        {
            App.inst.sfx.Play();
            if (!isRight)
                App.inst.uiMgr.matchTableMgr.SelectLeft();
            else
                App.inst.uiMgr.matchTableMgr.SelectRight();
            
            App.inst.uiMgr.matchTableMgr.SelectedItem(0);
            isRight = false;
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            App.inst.sfx.Play();
            App.inst.uiMgr.matchTableMgr.Hide(() =>
            {
                App.inst.uiMgr.matchTableMgr.Reset();
                App.inst.uiMgr.roundMgr.Show();
            });
        }
    }

    void ResultSelection()
    {
        Selection(KeyCode.RightArrow, KeyCode.LeftArrow, App.inst.uiMgr.resultMgr.btnImg.Length, (newIndex) =>
        {
            App.inst.sfx.Play();

            if (newIndex == 0)
            {
                App.inst.uiMgr.resultMgr.btnImg[0].OnBtn();
                App.inst.uiMgr.resultMgr.btnImg[1].OffBtn();
            }
            else
            {
                App.inst.uiMgr.resultMgr.btnImg[0].OffBtn();
                App.inst.uiMgr.resultMgr.btnImg[1].OnBtn();
            }
            isClick = (newIndex == 1);
        });

        if (Input.GetKeyDown(KeyCode.Return))
        {
            App.inst.sfx.Play();
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
            App.inst.uiMgr.resultMgr.UserSelected( );
        }
    }
    
    void Selection(KeyCode rightKey, KeyCode leftKey, int itemCount, System.Action<int> onItemSelected)
    {
        if (Input.GetKeyDown(rightKey))
        {
            App.inst.sfx.Play();
            // index = (index + 1) % itemCount;
            // onItemSelected(index);
            if (index < itemCount - 1)
            {
                index++;
                onItemSelected(index);
            }
        }
        else if (Input.GetKeyDown(leftKey))
        {
            App.inst.sfx.Play();
            
            if (index > 0)
            {
                index--;
                onItemSelected(index);
            }
            // index = (index - 1 + itemCount) % itemCount;
            // onItemSelected(index);
        }
    }

    public void GameStart()
    {
        isGameStarted = true;
        App.inst.sfx.Play();
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
        float centerOffset = (scrollViewWidth / 2 / contentWidth) * 0.025f;

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
