using UnityEngine;

public static class Calcs
{
	public static bool Decision(float trueChance, float falseChance)
	{
		float a = Random.Range(0, trueChance);
		float b = Random.Range(0, falseChance);
		if (a > b)
			return true;
		else
			return false;
	}
}
