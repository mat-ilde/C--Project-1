using System;
using EmployeeDetails;


namespace EmployeeDetailsImplementation
{


    // class ProgrammerIncharge implementing the interface Employee
    public class ProgrammerIncharge : IEmployee
    {
        String firtsName;
        String lastName;
        String activityProgrammerIncharge;
        DateTime activityDateStart;
        DateTime activityDateFinish;

        public ProgrammerIncharge(String firtsName, String lastName)
        {
            this.firtsName = firtsName;
            this.lastName = lastName;

        }


        public void SetFirstName(String firtsName)
        {
            this.firtsName = firtsName;

        }
        public void SetLastName(String lastName)
        {
            this.lastName = lastName;

        }

        public void SetActivity(String activity)
        {
            this.activityProgrammerIncharge = activity;


        }
        public void SetActivityDateStart(DateTime activityDateStart)
        {
            this.activityDateStart = activityDateStart;

        }
        public void SetActivityDateFinish(DateTime activityDateFinish)
        {
            this.activityDateFinish = activityDateFinish;

        }

        public String GetLastName()
        {
            return  lastName;
            
        }
        public String GetFirtsName()
        {
            return  firtsName ;

        }
        public String GetActivity()
        {
            return activityProgrammerIncharge;

        }
        public DateTime GetActivityDateStart()
        {
           return activityDateStart;

        }
        public DateTime GetActivityDateFinish()
        {
            return activityDateFinish;

        }
        
  
         public Double DurationOfProject(ProgrammerIncharge programmer){
            DateTime startDateOfProject=programmer.GetActivityDateStart();
            DateTime finishDateOfProject=programmer.GetActivityDateFinish();
            startDateOfProject=finishDateOfProject.AddHours(-1);
            
            TimeSpan ts = finishDateOfProject.Date.Subtract(startDateOfProject.Date) ;
            //Console.WriteLine(ts.TotalDays + " " + ts.TotalHours);  
          return (float)ts.TotalDays;
        }
        public override string ToString()
        {
            return lastName+","+ " " + firtsName+"," + " in charge of " + activityProgrammerIncharge + " from " + activityDateStart + " to " + activityDateFinish
            +"(duration " + this.DurationOfProject(this) + ")," +" this month:" + " n11 days " + "(total cost = n12 $) " +"\n";
        }
        
      






    }
}
