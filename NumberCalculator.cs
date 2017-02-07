﻿using System;

namespace Calculator
{
  public class NumberCalculator
  {
    public void PerformOneCalculation()
    {
      var op = Prompts.AskForString("Please enter the operator: ");
      var numbers = Prompts.AskForNumberArray(string.Format("Please enter the numbers to {0}. ", op));
      var answer = CalculateAnswer(op, numbers);

      Console.WriteLine("The answer is: {0}", answer);
      Console.WriteLine();
    }

    private int CalculateAnswer(string op, int[] numbers)
    {
      int answer = numbers[0];

      for (int index = 1; index < numbers.Length; index++)
      {
        if (op == "*")
        {
          answer = answer * numbers[index];
        }
        else if (op == "/")
        {
          answer = answer / numbers[index];
        }
        else if (op == "+")
        {
          answer = answer + numbers[index];
        }
        else if (op == "-")
        {
          answer = answer - numbers[index];
        }
      }
      return answer;
    }
  }
}