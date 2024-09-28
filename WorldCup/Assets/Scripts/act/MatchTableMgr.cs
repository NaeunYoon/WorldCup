using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MatchTableMgr : UIBase
{
    public TextMeshProUGUI txt = null;
    public TextMeshProUGUI cnt = null;
    public int count = 0;
    public List<MatchPrefab> matchList;
    
    public int categoryIndex = 0;
    public int RoundIndex = 0;
    public List <Dictionary<string, Sprite>> directoryImgList = new List<Dictionary<string, Sprite>>();
    public Dictionary<string, Sprite> curCategoryGameDic = new Dictionary<string, Sprite>();
    public List<KeyValuePair<string, Sprite>> currentRoundPairs = new List<KeyValuePair<string, Sprite>>();
    
    public override void Create()
    {
        base.Create();
        
    }
    public override void Show()
    {
        base.Show();
        matchList[0].Selected();
        txt.text = App.inst.controller.selectedcategoryName + App.inst.controller.selectedRound;
        InitImg();
        StartGame(RoundIndex);
    }
    
    public void SelectedItem(int idx)
    {
        for (int i = 0; i < matchList.Count; i++)
        {
            matchList[i].NoneSelected();
        }
        matchList[idx].Selected();
    }

    public void InitImg()
    {
        curCategoryGameDic = directoryImgList[categoryIndex];
    }

    public void StartGame(int roundSize)
    {
        currentRoundPairs = new List<KeyValuePair<string, Sprite>>(curCategoryGameDic);
        Shuffle(currentRoundPairs);

        ShowNextPair();
    }
    
    void Shuffle(List<KeyValuePair<string, Sprite>> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int randomIndex = Random.Range(0, i + 1);
            var temp = list[i];
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }
    private int currentPairIndex = 0;
    void ShowNextPair()
    {
        if (currentRoundPairs.Count > currentPairIndex)
        {
            matchList[0].text.text = currentRoundPairs[currentPairIndex].Key;
            matchList[0].img.sprite = currentRoundPairs[currentPairIndex].Value;
            matchList[1].text.text = currentRoundPairs[currentPairIndex + 1].Key;
            
            matchList[1].img.sprite = currentRoundPairs[currentPairIndex + 1].Value;
        }
        else
        {
            PrepareNextRound();
        }
    }
    void PrepareNextRound()
    {
        if (nextRoundPairs.Count == 1)
        {
            ShowWinner(nextRoundPairs[0]);
        }
        else
        {
            currentRoundPairs = new List<KeyValuePair<string, Sprite>>(nextRoundPairs);
            nextRoundPairs.Clear();
            currentPairIndex = 0;
            ShowNextPair();
        }
    }
    public void SelectLeft()
    {
        AdvanceToNextRound(currentRoundPairs[currentPairIndex]);
        Count();
    }

    public void SelectRight()
    {
        AdvanceToNextRound(currentRoundPairs[currentPairIndex + 1]);
        Count();
    }
    public void Count()
    {
        count++;
        cnt.text = count.ToString();
    }
    public List<KeyValuePair<string, Sprite>> nextRoundPairs = new List<KeyValuePair<string, Sprite>>();
    void AdvanceToNextRound(KeyValuePair<string, Sprite> selectedPair)
    {
        nextRoundPairs.Add(selectedPair);
        currentPairIndex += 2;
        if (currentPairIndex >= App.inst.controller.selectedRound) 
        {
            App.inst.controller.selectedRound /= 2;
            PrepareNextRound();
        }
        else
        {
            ShowNextPair();
        }
    }
    void ShowWinner(KeyValuePair<string, Sprite> winner)
    {
        matchList[0].img.sprite = winner.Value;
        matchList[0].text.text = "Winner: " + winner.Key;

        matchList[1].gameObject.SetActive(false);
    }

    public void Reset()
    {
        matchList[1].gameObject.SetActive(true);
        matchList[0].img.sprite = null;
        matchList[0].text.text = "";
    
        currentPairIndex = 0;
        RoundIndex = 0;
        count = 0;
        cnt.text = string.Empty;
        
        nextRoundPairs.Clear();
        currentRoundPairs.Clear();

    }
    
    public override void Hide()
    {
        base.Hide();
    }
    
}
