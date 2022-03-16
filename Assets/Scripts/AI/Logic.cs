using UnityEngine;

public class Logic : QuestionsFlow_1
{
	public Vector2 LogicOrFree;
	[Range(-200, 200)] public float tryToLast;		//-will do anything to stay alive | +free choice for anything wanted
	[Range(-200, 200)] public float passion;		//-make wonder and full of try | +make biased choice and need more!
	[Range(-200, 200)] public float trust;			//-make choose carefully | +make choose blindly
	[Range(-200, 200)] public float wealth;			//-stop spending money | +paying for anything wanted
	[Range(-200, 200)] public float goodAndBad;		//-will broke you up | +will destroy you
	[Range(-200, 200)] public float greed;			//-blessing choices | +broke trusts and selfish

	private HumanNature m_HumanNature;

	private void Start()
	{
		m_HumanNature = GetComponent<HumanNature>();
	}

	private void Update()
	{
		tryToLast = ((-m_HumanNature.hunger * 5) + (-m_HumanNature.hobby * 2) + (passion) + (-trust * 4) + (-wealth * 3) + greed) / 16;

	}
}
