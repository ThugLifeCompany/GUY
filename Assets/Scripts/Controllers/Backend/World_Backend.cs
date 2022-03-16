using UnityEngine;

[System.Serializable]
public class RealTime 
{
	public float seconds;
	public float minutes;
	public float hours;
}

public abstract class World_Backend : MonoBehaviour
{
	[HideInInspector] public RealTime time;
	[SerializeField] protected float extraTimeSpeed;

	protected void CalculateTime()
	{
		time.seconds += Time.deltaTime * extraTimeSpeed;
		if (time.seconds >= 60)
		{
			time.minutes++;
			time.seconds = 0;
		}

		if (time.minutes >= 60)
		{
			time.hours++;
			time.minutes = 0;
		}

		if (time.hours >= 24)
		{
			time.seconds = 0;
			time.minutes = 0;
			time.hours = 0;
		}
	}

}
