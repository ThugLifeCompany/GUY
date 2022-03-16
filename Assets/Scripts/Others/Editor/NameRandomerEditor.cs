using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(NameRandomer))]
public class NameRandomerEditor : Editor
{
	const string glyphs = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

	SerializedProperty XpreName;
	SerializedProperty Xuniqe;
	SerializedProperty XminLength;
	SerializedProperty XmaxLenght;

	private void OnEnable()
	{
		XpreName = serializedObject.FindProperty("preName");
		Xuniqe = serializedObject.FindProperty("uniqe");
		XminLength = serializedObject.FindProperty("minLength");
		XmaxLenght = serializedObject.FindProperty("maxLength");
	}

	public override void OnInspectorGUI()
	{
		serializedObject.Update();
		EditorGUILayout.HelpBox("With this script you can Randomiz a name for your GameObject", MessageType.Info);

		NameRandomer nameRandomer = (NameRandomer)target;

		EditorGUILayout.PropertyField(XpreName);
		EditorGUILayout.PropertyField(Xuniqe);
		EditorGUILayout.PropertyField(XminLength);
		EditorGUILayout.PropertyField(XmaxLenght);
		if (GUILayout.RepeatButton(nameRandomer.gameObject.name + "\nSelect To Make Random Name", GUILayout.Height(50)))
			MakeRandomName(nameRandomer, nameRandomer.uniqe, nameRandomer.minLength, nameRandomer.maxLength);
		serializedObject.ApplyModifiedProperties();
	}

	private void MakeRandomName(NameRandomer nameRandomer, bool uniqe, int minLength, int maxLength)
	{
		string namex = string.Empty;
		namex = "House_";
		int charAmount = Random.Range(minLength, maxLength);
		for (int i = 0; i < charAmount; i++)
			namex += glyphs[Random.Range(0, glyphs.Length)];

		nameRandomer.gameObject.name = namex;
	}
}
