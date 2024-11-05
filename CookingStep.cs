using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccurateRecipeRecordingandCalculationSoftware
{
     public class CookingStep
    {
        public string StepInfo { get; set; }
        public int StepNumber { get; set; }
        public string StepTime { get; set; }


        public CookingStep(string stepInfo, int stepNumber, string stepTime)
        {
            StepInfo = stepInfo;
            StepNumber = stepNumber;
            StepTime = stepTime;

        }

    }
}
