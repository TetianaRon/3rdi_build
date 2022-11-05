using Assets.Scripts.LogicCore;
using UnityEngine;

namespace Assets
{
    public class ClickableExponat : MonoBehaviour
    {
        [SerializeField]
        private ExponentContent _content;

        public void Click()
        {
            PanelManger.ExponatClicked(_content);

        } 
    }
}