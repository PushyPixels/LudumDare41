﻿#if UNITY_EDITOR
using ListView;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.EditorVR
{
    sealed class HierarchyData : ListViewItemNestedData<HierarchyData, int>
    {
        const string k_TemplateName = "HierarchyListItem";

        public string name { get; set; }

        public override int index
        {
            get { return instanceID; }
        }

        public int instanceID { private get; set; }

        public GameObject gameObject { get { return (GameObject)EditorUtility.InstanceIDToObject(instanceID); } }

        public HashSet<string> types { get; set; }

        public HierarchyData(HierarchyProperty property)
        {
            template = k_TemplateName;
            name = property.name;
            instanceID = property.instanceID;
        }
    }
}
#endif
