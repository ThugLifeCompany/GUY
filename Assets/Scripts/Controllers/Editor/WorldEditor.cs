using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(World))]
public class WorldEditor : Editor
{
	SerializedProperty floatExtraTimeSpeed;

	void OnEnable()
	{
		floatExtraTimeSpeed = serializedObject.FindProperty("extraTimeSpeed");
	}

	public override void OnInspectorGUI()
	{
		serializedObject.Update();
		World world = (World)target;

		string dayOrNight = string.Empty;

		if (world.time.hours <= 12)
			dayOrNight = "AM";
		else
			dayOrNight = "PM";
		
		GUILayout.Label(string.Format("Time\t{0}:{1}:{2} " + dayOrNight, world.time.hours.ToString("00"), world.time.minutes.ToString("00"), world.time.seconds.ToString("00")));

		EditorGUILayout.PropertyField(floatExtraTimeSpeed);
		serializedObject.ApplyModifiedProperties();
	}
}