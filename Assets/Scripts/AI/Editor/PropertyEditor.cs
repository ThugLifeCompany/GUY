using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Property))]
public class PropertyEditor : Editor
{
	const string glyphs = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

	SerializedProperty Xmoney;
	SerializedProperty Xhouse;
	SerializedProperty Xcar;
	SerializedProperty Xwife;
	SerializedProperty Xchild;

	void OnEnable()
	{
		Xmoney = serializedObject.FindProperty("money");
		Xhouse = serializedObject.FindProperty("house");
		Xcar = serializedObject.FindProperty("car");
		Xwife = serializedObject.FindProperty("wife");
		Xchild = serializedObject.FindProperty("child");
	}

	public override void OnInspectorGUI()
	{
		serializedObject.Update();
		Property propertyx = (Property)target;

		if (GUILayout.RepeatButton("Name:\t" + propertyx.AI_Name.Substring(3), GUILayout.Height(30)))
			MakeRandomName(propertyx);

		EditorGUILayout.PropertyField(Xmoney);
		EditorGUILayout.PropertyField(Xhouse);
		EditorGUILayout.PropertyField(Xcar);
		EditorGUILayout.PropertyField(Xwife);
		EditorGUILayout.PropertyField(Xchild);
		serializedObject.ApplyModifiedProperties();
	}

	private void MakeRandomName(Property propertyx)
	{
		string namex = string.Empty;
		namex = "AI_";
		int charAmount = Random.Range(4, 7);
		for (int i = 0; i < charAmount; i++)
		{
			namex += glyphs[Random.Range(0, glyphs.Length)];
		}
		propertyx.GetTheName(namex);
		propertyx.gameObject.name = namex;
	}
}
