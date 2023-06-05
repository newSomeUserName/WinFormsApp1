using Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class GradeCalculation
    {
        static public void CalculateGradeWithTime(this TeachersCharacteristics teachersCharacteristics, double grade)
        {
            // if (teachersCharacteristics.LastEditedTime - DateTime.Now == new TimeSpan(0, 0, 30, 0, 0))
            //  throw new Exception("Ваш запрос не смог быть обработан");
            teachersCharacteristics.Grade.Add(grade);
            double averageGrade = teachersCharacteristics.Grade.Sum() / teachersCharacteristics.Grade.Count;

            if (teachersCharacteristics.Grade.Count > 25 || !teachersCharacteristics.IsAlernt)
            {
                if (averageGrade <= 2)
                {
                    teachersCharacteristics.GetAlernt("прерпод занижает оценки");
                }
                if (averageGrade > 4.8)
                {
                    teachersCharacteristics.GetAlernt("прерпод покупает учеников");
                }
                teachersCharacteristics.IsAlernt = true;

            }
            teachersCharacteristics.LastEditedTime = DateTime.Now;

            teachersCharacteristics.AverageGrade = averageGrade;
        }
        //TO DO: complete
        static public CriterionEnum GetCriterion()
        {
            return CriterionEnum.Availibility | CriterionEnum.Competentce;
        }
    }
}
