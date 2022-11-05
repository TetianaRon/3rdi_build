using System;
using UnityEngine;

namespace Assets.Scripts.LogicCore
{
    [Serializable]
    public class QuizQuestion{

        public string Name;
        [TextArea]
        public string Description; 

        public string[] Options;
        [Tooltip("Indexing start with 0. If the first anser is right that put 0 here")]
        public int RightAnswer;

    }
}