using System.Collections.Generic;
using System;

public class CookingStep
{
    public string StepInfo { get; set; }
    public int StepNumber { get; set; }
    public TimeSpan StepTime { get; set; }
    public List<int> Dependencies { get; set; }
    public bool CanRunInParallel { get; set; }

    public CookingStep(string stepInfo, int stepNumber, TimeSpan stepTime)
    {
        StepInfo = stepInfo;
        StepNumber = stepNumber;
      
        Dependencies = new List<int>();
    }
}
