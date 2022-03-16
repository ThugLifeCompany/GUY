using UnityEngine;

public class Think : QuestionsFlow_1
{
	public float decisionSpeedPerSec = 1;

	public Question[] tryToLastQuestions;
	public Question[] passionQuestions;
	public Question[] trustQuestions;
	public Question[] wealthQuestions;
	public Question[] goodAndBadQuestions;
	public Question[] greedQuestions;
	public Question[] freeQuestions;

	//Will Log Brain Thinking Messages
	public string brainMessages = "What Should I Do?";

	public void ShowBrainMessages(string message) => brainMessages = message;

	private void Start()
	{
		AskAFreeQuestion();
	}

	public void AskAFreeQuestion()
	{
		var i = Random.Range(0, freeQuestions.Length);
		//GetFunctionOfThisQuestion(freeQuestions[i].question);
	}
}
