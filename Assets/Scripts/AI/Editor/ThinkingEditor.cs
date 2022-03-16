using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Think))]
public class ThinkingEditor : Editor
{
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();
		Think thinking = (Think)target;

		GUILayout.Space(5);
		GUILayout.Label("-------------------------------------------------------------------------------------");
		GUILayout.Label(("Brain Messages"));
		EditorGUILayout.HelpBox(thinking.brainMessages, MessageType.Info);
	}
}