using Application.Enums;
using Application.EventHandlers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class TeachersCharacteristics
    {
        public string FullName { get; }

        public int Qualification { get; }

        public int Age { get; }

        public List<double> Grade { get; private set; }

        public double AverageGrade { get; set; }

        public ObservableCollection<double> OGrade { get; private set; }

        public CriterionEnum? CriterionEnum { get; set; }

        public DateTime LastEditedTime { get; set; }

        public bool IsAlernt { get; set; }

        public EventHandler<GradeEventHandler> Handler { get; set; }

        public TeachersCharacteristics(string fullname, int qualification, EventHandler<GradeEventHandler> handlerGrade)
        {
            Grade = new List<double>();
            FullName = fullname;
            Qualification = qualification;
            Handler = handlerGrade;

        }
        public TeachersCharacteristics(string fullname, int qualification, EventHandler<GradeEventHandler> handlerGrade, int age) : this(fullname, qualification, handlerGrade)
        {
            Age = age;
        }
        public void GetAlernt(string message)
        {
            Handler.Invoke(this, new GradeEventHandler(message));
        }
    }
}
