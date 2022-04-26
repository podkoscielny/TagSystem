using System;
using System.Collections.Generic;
using UnityEngine;

namespace AoOkami.MultipleTagSystem
{
    public class TagManager : MonoBehaviour
    {
        [SerializeField] List<Tags> tags = new List<Tags>();

        private void OnEnable()
        {
            RemoveDuplicatesFromTags();
            TagSystem.CacheObjectToTagSystem(gameObject, tags);
        }

        private void OnDisable() => TagSystem.RemoveObjectFromTagSystem(gameObject, tags);

        public bool HasTag(Tags tag) => TagSystem.HasTag(tag, gameObject);

        public void AddTag(Tags tag)
        {
            if (tags.Contains(tag)) return;

            tags.Add(tag);
            TagSystem.CacheObjectToNewTag(gameObject, tag);
        }

        public void RemoveTag(Tags tag)
        {
            if (!tags.Contains(tag)) return;

            tags.Remove(tag);
            TagSystem.RemoveTagFromObject(gameObject, tag);
        }

        private void RemoveDuplicatesFromTags()
        {
            List<Tags> tagsWithoutDuplicates = new List<Tags>();

            foreach (Tags tag in tags)
            {
                if (tagsWithoutDuplicates.Contains(tag)) continue;

                tagsWithoutDuplicates.Add(tag);
            }

            tags = tagsWithoutDuplicates;
        }
    }
}
