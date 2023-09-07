using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TiltBrush.FrameAnimation
{
    public class AddKeyframeButton : BaseButton
    {
        [SerializeField] private UnityEngine.Events.UnityEvent m_Action;

        protected override void OnButtonPressed()
        {
            // m_Action.Invoke();
            var uiManager = GetComponentInParent<AnimationUI_Manager>();
            uiManager.addKeyFrame();
            
        }
    }
} // namespace TiltBrush