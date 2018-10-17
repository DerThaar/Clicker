using UnityEngine;

public class NumberHelper: MonoBehaviour
{	
	public string GoldCalculation(float gold)
	{
		string goldText;

		if (gold >= 18446744073709551615)
		{
			gold = 18446744073709551615;
			goldText = " very much Gold";
		}
		else if (gold >= 1000000000000000000)
		{
			goldText = (Mathf.Round((gold / 1000000000000000000) * 1000) / 1000).ToString("0.000") + " quintillion Gold";
		}
		else if (gold >= 1000000000000000)
		{
			goldText = (Mathf.Round((gold / 1000000000000000) * 1000) / 1000).ToString("0.000") + " quadrillion Gold";
		}
		else if (gold >= 1000000000000)
		{
			goldText = (Mathf.Round((gold / 1000000000000) * 1000) / 1000).ToString("0.000") + " trillion Gold";
		}
		else if (gold >= 1000000000)
		{
			goldText = (Mathf.Round((gold / 1000000000) * 1000) / 1000).ToString("0.000") + " billion Gold";
		}
		else if (gold >= 1000000)
		{
			goldText = (Mathf.Round((gold / 1000000) * 1000) / 1000).ToString("0.000") + " million Gold";
		}
		else
		{			
			goldText = gold.ToString("0") + " Gold";
		}

		return goldText;
	}
}
