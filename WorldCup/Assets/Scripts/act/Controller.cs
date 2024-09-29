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
    void Update()
    {
        if (!isGameStarted && App.inst.uiMgr.openingMgr.IsShow())
        {
            if(Input.GetKeyDown(KeyCode.A))
                GameStart();
        }

        if (isGameStarted && App.inst.uiMgr.categoryMgr.IsShow())
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                index = (index + 1) % App.inst.uiMgr.categoryMgr.categoryList.Count;
                App.inst.uiMgr.categoryMgr.SelectedItem(index);
                App.inst.uiMgr.matchTableMgr.categoryIndex = index;
                selectedcategoryName = App.inst.uiMgr.categoryMgr.categoryList[index].name;
                ScrollToSelected(App.inst.uiMgr.categoryMgr.categoryList[index].gameObject,App.inst.uiMgr.categoryMgr.rect);
            }
            else if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                index = (index - 1 + App.inst.uiMgr.categoryMgr.categoryList.Count) % App.inst.uiMgr.categoryMgr.categoryList.Count; 
                App.inst.uiMgr.categoryMgr.SelectedItem(index);
                App.inst.uiMgr.matchTableMgr.categoryIndex = index;
                selectedcategoryName = App.inst.uiMgr.categoryMgr.categoryList[index].name;
                ScrollToSelected(App.inst.uiMgr.categoryMgr.categoryList[index].gameObject,App.inst.uiMgr.categoryMgr.rect);
                
            }else if (Input.GetKeyDown(KeyCode.Return))
            {
                App.inst.uiMgr.categoryMgr.Hide(() =>
                {
                    index = 0;
                    App.inst.uiMgr.roundMgr.Show();
                });
            }
        }
        
        if (isGameStarted && App.inst.uiMgr.roundMgr.IsShow())
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                index = (index + 1) % App.inst.uiMgr.roundMgr.roundList.Count;
                App.inst.uiMgr.roundMgr.SelectedItem(index);
                App.inst.uiMgr.matchTableMgr.RoundIndex = index;
                selectedRound = App.inst.uiMgr.roundMgr.roundList[index].round;
            }
            else if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                index = (index - 1 + App.inst.uiMgr.roundMgr.roundList.Count) % App.inst.uiMgr.roundMgr.roundList.Count; 
                App.inst.uiMgr.roundMgr.SelectedItem(index);
                App.inst.uiMgr.matchTableMgr.RoundIndex = index;
                selectedRound = App.inst.uiMgr.roundMgr.roundList[index].round;
                
            }else if (Input.GetKeyDown(KeyCode.Return))
            {
                App.inst.uiMgr.roundMgr.Hide(() =>
                {
                    index = 0;
                    App.inst.uiMgr.matchTableMgr.Show();
                });
            }
        }
        
        if (isGameStarted && App.inst.uiMgr.matchTableMgr.IsShow())
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                index = (index + 1) % App.inst.uiMgr.matchTableMgr.matchList.Count;
                App.inst.uiMgr.matchTableMgr.SelectedItem(index);
                isRight = true;
            }
            else if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                index = (index - 1 + App.inst.uiMgr.matchTableMgr.matchList.Count) % App.inst.uiMgr.matchTableMgr.matchList.Count; 
                App.inst.uiMgr.matchTableMgr.SelectedItem(index);
                isRight = false;
                
            }else if (Input.GetKeyDown(KeyCode.Return))
            {
                if(!isRight)
                    App.inst.uiMgr.matchTableMgr.SelectLeft();
                else
                    App.inst.uiMgr.matchTableMgr.SelectRight();
                
                
            }else if (Input.GetKeyDown(KeyCode.X))
            {
                App.inst.uiMgr.matchTableMgr.Hide(() =>
                {
                    App.inst.uiMgr.matchTableMgr.Reset();
                    App.inst.uiMgr.roundMgr.Show();
                });
            }
        }
        
        if (isGameStarted && App.inst.uiMgr.resultMgr.IsShow())
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                index = (index + 1) % App.inst.uiMgr.resultMgr.btnImg.Length;
                App.inst.uiMgr.resultMgr.btnImg[0].color = Color.white;
                App.inst.uiMgr.resultMgr.btnImg[1].color = Color.yellow;
                isClick = true;
            }
            else if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                index = (index - 1 + App.inst.uiMgr.resultMgr.btnImg.Length) % App.inst.uiMgr.resultMgr.btnImg.Length; 
                App.inst.uiMgr.resultMgr.btnImg[0].color = Color.yellow;
                App.inst.uiMgr.resultMgr.btnImg[1].color = Color.white;
                isClick = false;

            }else if (Input.GetKeyDown(KeyCode.Return))
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
            }
        }
    }

    public bool isRight = false;
    public bool isClick = false;
    public void GameStart()
    {
        isGameStarted = true;
        App.inst.uiMgr.openingMgr.Hide(()=>{
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
        float centerOffset = (scrollViewWidth / 2 / contentWidth)*0.05f;

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
