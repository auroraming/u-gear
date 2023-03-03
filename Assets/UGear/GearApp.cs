using System;
using UnityEngine;

namespace UGear
{
    public class GearApp : MonoBehaviour
    {
        private void Start()
        {
            InitApp();
        }
        /// <summary>
        /// 初始化框架
        /// </summary>
        private void InitApp()
        {
            #if UNITY_EDITOR
            Debug.Log("初始化");
#endif
        }
    }
}