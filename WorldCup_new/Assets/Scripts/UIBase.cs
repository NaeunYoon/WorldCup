using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public abstract class UIBase : MonoBehaviour
{
    public Animator animator = null;
    public CanvasGroup root = null;
    private Coroutine _cor = null;
    private Action _onFinished = null;

    private UIDirectionStateType crnDirection = UIDirectionStateType.NONE;
    private enum UIDirectionStateType
    {
        NONE,
        INIT,
        SHOW,
        SHOW_IDLE,
        HIDE,
        HIDE_IDLE,
    }

    public virtual void Create()
    {

    }

    public virtual void Delete()
    {
        Stop();
    }

    #region Show
    public virtual void Show()
    {
        Stop();

        ChangeDirectionState(UIDirectionStateType.SHOW_IDLE);
    }
    public virtual void Show(Action onfinished)
    {
        _onFinished = onfinished;
        _cor = StartCoroutine(_Show());
        
        if(onfinished != null)
            onfinished.Invoke();
    }
    
    public virtual bool IsShow()
    {
        return root.gameObject.activeSelf && root.alpha > 0.0f;
    }
    
    protected virtual IEnumerator _Show()
    {
        ChangeDirectionState(UIDirectionStateType.SHOW);
        while(!IsDirectionState(UIDirectionStateType.SHOW_IDLE))
        {
            yield return null;
        }
    }
    #endregion Show

    #region Hide
    public virtual void Hide() 
    {
        Stop();

        ChangeDirectionState(UIDirectionStateType.HIDE_IDLE);
    }

    public virtual void Hide(Action onFinished)
    {
        Stop();

        _onFinished = onFinished;
        _cor = StartCoroutine(_Hide());
    }
    protected virtual IEnumerator _Hide()
    {
        ChangeDirectionState(UIDirectionStateType.HIDE);

        while (!IsDirectionState(UIDirectionStateType.HIDE_IDLE))
        {
            yield return null;
        }

        Complete();
    }

    #endregion Hide

    private bool ChangeDirectionState(UIDirectionStateType  uiDirection)
    {
        if (!CanChangeDirectionState(uiDirection))
        {
            return false;
        }

        animator.Play(uiDirection.ToString());
        crnDirection = uiDirection;

        return true;
    }

    private bool CanChangeDirectionState(UIDirectionStateType uiDirectionStateType)
    {
        var uiDirectionStateTypeName = uiDirectionStateType.ToString();
        return !animator.GetAnimatorTransitionInfo(0).IsName(uiDirectionStateTypeName) && !animator.GetCurrentAnimatorStateInfo(0).IsName(uiDirectionStateTypeName);
    }
    
    private bool IsDirectionState(UIDirectionStateType uiDirection)
    {
        return animator.GetCurrentAnimatorStateInfo(0).IsName(uiDirection.ToString());
    }
    protected void Stop()
    {
        if(_cor != null)
        {
            StopCoroutine(_cor);
            _cor= null;
        }

        if(_onFinished != null)
        {
            var onfinished = _onFinished;
            _onFinished= null;
            onfinished();
        }
    }
    protected void Complete()
    {
        if (_onFinished != null)
        {
            var onfinished = _onFinished;
            _onFinished = null;
            onfinished();
        }
    }


}
