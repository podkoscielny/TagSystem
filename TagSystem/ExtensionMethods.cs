using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AoOkami.MultipleTagSystem
{
    public static class ExtensionMethods
    {
        public static bool HasTag(this GameObject gameObject, Tags tag) => TagSystem.HasTag(tag, gameObject);

        public static bool HasTag(this Collision collision, Tags tag) => TagSystem.HasTag(tag, collision.gameObject);

        public static bool HasTag(this Collider collision, Tags tag) => TagSystem.HasTag(tag, collision.gameObject);

        public static bool HasTag(this Collision2D collision, Tags tag) => TagSystem.HasTag(tag, collision.gameObject);

        public static bool HasTag(this Collider2D collision, Tags tag) => TagSystem.HasTag(tag, collision.gameObject);
    }
}
