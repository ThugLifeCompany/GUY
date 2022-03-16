using UnityEngine;

public class Property : MonoBehaviour
{
	public string AI_Name;
	public int money;
	public string house;
	public string car;
	public string wife;
	public string[] child;

	//Editor-----------------------------------------------
	public void GetTheName(string namex) => AI_Name = namex;
}
