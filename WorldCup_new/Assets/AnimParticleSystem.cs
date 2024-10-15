using System.Collections;
using System.Collections.Generic;
using Coffee.UIExtensions;
using UnityEngine;

public class AnimParticleSystem : MonoBehaviour
{
    public UIParticle vs1 = null;
    public UIParticle vs2 = null; 
    
    public void OnBigVsEffect()
   {
       vs1.Play();
   }
   public void OffBigVsEffect()
   {
       vs1.Stop();
   }
   public void OnSmallVsEffect()
   {
       vs2.Play();
   }
   public void OffSmallVsEffect()
   {
       vs2.Stop();
   }
    
    
}
