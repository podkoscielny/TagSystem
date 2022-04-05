using System;
using System.Collections.Generic;
using UnityEngine;
using Tags = AoOkami.MultipleTagSystem.TagSystem.Tags;

namespace AoOkami.MultipleTagSystem
{
    public class TagManager : MonoBehaviour
    {
        [SerializeField] List<Tags> tags = new List<Tags>();

        private void OnEnable() => TagSystem.CacheObjectToTagSystem(gameObject, tags);

        private void OnDisable() => TagSystem.RemoveObjectFromTagSystem(gameObject, tags);

        private void OnValidate() => PreventFromDuplicatingTags();

        public bool HasTag(Tags tag) => tags.Contains(tag);

        public void AddTag(Tags tag)
        {
            if (tags.Contains(tag) || tag == Tags.None) return;

            tags.Add(tag);
            TagSystem.CacheObjectToNewTag(gameObject, tag);
        }

        public void RemoveTag(Tags tag)
        {
            if (!tags.Contains(tag) || tag == Tags.None) return;
            
            tags.Remove(tag);
            TagSystem.RemoveTagFromObject(gameObject, tag);
        }

        private void PreventFromDuplicatingTags()
        {
            List<Tags> tagsWithoutDuplicates = new List<Tags>();

            foreach (Tags tag in tags)
            {
                if (tagsWithoutDuplicates.Contains(tag))
                {
                    tagsWithoutDuplicates.Add(Tags.None);
                    continue;
                }

                tagsWithoutDuplicates.Add(tag);
            }

            tags = tagsWithoutDuplicates;
        }
    }
}
