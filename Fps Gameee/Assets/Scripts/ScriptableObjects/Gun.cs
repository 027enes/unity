using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Com.Kawaiisun.SimpleHostile
{
    [CreateAssetMenu(fileName = "New Gun", menuName = "Gun")]
    public class Gun : ScriptableObject
    {
        public new string name;
        public float firerate;
        public float aimSpeed;
        public GameObject prefab;
    }
}

