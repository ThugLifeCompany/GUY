using System;

public enum m_Functionality
{
	MMD,
	ALI,
	HOSSEIN
}

[Serializable]
public class Question
{
	public string question;
	public float minLogic;
	public float maxLogic;
	public m_Functionality functionality = m_Functionality.MMD;
}
