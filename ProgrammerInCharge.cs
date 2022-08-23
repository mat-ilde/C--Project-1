using System;
using EmployeeDetails;


namespace EmployeeDetailsImplementation
{


    // class ProgrammerIncharge implementing the interface Employee
    public class ProgrammerIncharge : IEmployee
    {
        String? firtsName;
        String? lastName;
        String? activityProgrammerIncharge;
        String? activityDateStart;
        String? activityDateFinish;

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
        public void SetActivityDateStart(String activityDateStart)
        {
            this.activityDateStart = activityDateStart;

        }
        public void SetActivityDateFinish(String activityDateFinish)
        {
            this.activityDateFinish = activityDateFinish;

        }

        public void GetLastName()
        {
            Console.Write(lastName + " ");

        }
        public void GetFirtsName()
        {
            Console.Write(firtsName + " ");

        }
        public void GetActivity()
        {
            Console.Write(activityProgrammerIncharge + " ");

        }
        public void GetActivityDateStart()
        {
            Console.Write(activityDateStart + " ");

        }
        public void GetActivityDateFinish()
        {
            Console.Write(activityDateFinish + " ");

        }
        public override string ToString()
        {
            return lastName +" " + firtsName +" " + activityProgrammerIncharge +" "+ activityDateFinish + " "+ activityDateFinish + "\n";
        }






    }
}
