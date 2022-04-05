using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace AoOkami.MultipleTagSystem
{
    public static class TagSystem
    {
        [Serializable]
        public enum Tags
        {
            None = 0,
            Example = 1
        }

        private static Dictionary<Tags, List<GameObject>> _taggedObjects = new Dictionary<Tags, List<GameObject>>();
        private static Dictionary<Tags, ReadOnlyCollection<GameObject>> _readonlyObjects = new Dictionary<Tags, ReadOnlyCollection<GameObject>>();

        private static ReadOnlyCollection<GameObject> _emptyList = new List<GameObject>().AsReadOnly();

        static TagSystem()
        {
            InitializeTaggedObjectsDictionary();
        }

        public static GameObject FindGameObjectWithTag(Tags tag)
        {
            if (!_taggedObjects.ContainsKey(tag) || _taggedObjects[tag].Count < 1) return null;

            return _taggedObjects[tag][0];
        }

        public static ReadOnlyCollection<GameObject> FindAllGameObjectsWithTag(Tags tag)
        {
            if (!_taggedObjects.ContainsKey(tag) || _taggedObjects[tag].Count < 1) return _emptyList;

            return _readonlyObjects[tag];
        }

        internal static void CacheObjectToTagSystem(this TagManager tagManager, GameObject objectToBeCached, List<Tags> tags)
        {
            foreach (var item in _taggedObjects)
            {
                if (tags.Contains(item.Key) && item.Key != Tags.None)
                    _taggedObjects[item.Key].Add(objectToBeCached);
            }
        }

        internal static void RemoveObjectFromTagSystem(this TagManager tagManager, GameObject objectToBeRemoved, List<Tags> tags)
        {
            foreach (var item in _taggedObjects)
            {
                if (tags.Contains(item.Key))
                    _taggedObjects[item.Key].Remove(objectToBeRemoved);
            }
        }

        private static void InitializeTaggedObjectsDictionary()
        {
            Type enumType = typeof(Tags);
            var enumValues = Enum.GetValues(enumType);

            foreach (var value in enumValues)
            {
                _taggedObjects.Add((Tags)value, new List<GameObject>());
            }

            foreach (var item in _taggedObjects)
            {
                _readonlyObjects.Add(item.Key, item.Value.AsReadOnly());
            }
        }
    }
}
