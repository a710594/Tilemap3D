using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MapFileGenerator))]
public class MapFileGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        MapFileGenerator nodeGenerator = (MapFileGenerator)target;
        if (GUILayout.Button("�إ��ɮ�"))
        {
            nodeGenerator.BuildFile();
        }
        if (GUILayout.Button("���J�ɮ�"))
        {
            nodeGenerator.LoadFile();
        }
    }
}
