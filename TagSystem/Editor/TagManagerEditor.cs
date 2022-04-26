using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

#if UNITY_EDITOR
namespace AoOkami.MultipleTagSystem
{
    [CustomEditor(typeof(TagManager))]
    public class TagManagerEditor : Editor
    {
        private SerializedProperty _tags;

        private void OnEnable()
        {
            _tags = serializedObject.FindProperty("tags");
        }

        public override void OnInspectorGUI()
        {
            if (!EditorApplication.isPlaying)
            {
                base.OnInspectorGUI();
            }
            else
            {
                for (int i = 0; i < _tags.arraySize; i++)
                {
                    int tagIndex = _tags.GetArrayElementAtIndex(i).enumValueIndex;
                    Tags tagToDisplay = (Tags)tagIndex;

                    EditorGUILayout.LabelField($"{tagToDisplay}");
                }
            }
        }
    }
}
#endif
