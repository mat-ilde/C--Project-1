using System;
using EmployeeDetails;
using System.Collections.Generic; 



namespace EmployeeDetailsImplementation
{


    // class ProgrammerIncharge implementing the interface Employee
    public class ProgrammerIncharge : IEmployee
    {
        private String firtsName;
        private String lastName;
        private String activityProgrammerIncharge;
        private List<String> activityDateStart=new List<String>();
        private List<String> activityDateFinish=new List<String>();


        public ProgrammerIncharge(String firtsName, String lastName)
        {
            this.firtsName = firtsName;
            this.lastName = lastName;

        }


        public void AddFirstName(String firtsName)
        {
            this.firtsName = firtsName;

        }
        public void AddLastName(String lastName)
        {
            this.lastName = lastName;

        }

        public void AddActivity(String activity)
        {
            this.activityProgrammerIncharge = activity;


        }
        public void AddActivityDateStart(String year, String month, String day)
        {
            this.activityDateStart.Add(year);
            this.activityDateStart.Add(month);
            this.activityDateStart.Add(day);


            /*this.activityDateStart[1] = month;
            this.activityDateStart[2] = year;*/

        }
        public void AddActivityDateFinish(String year, String month, String day)
        {
            this.activityDateFinish.Add(year);
            this.activityDateFinish.Add(month);
            this.activityDateFinish.Add(year);

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
        public String GetActivityDateStart()
        {   
            String startDate="";
            //string myString="";
            
            foreach(String date in activityDateStart){
                
                startDate = startDate+date+" ";
                
            }
           
           return startDate + " \n";

        }
        public String GetActivityDateFinish()
        {
            String finishDate="";
            //string myString="";
            
            foreach(String date in activityDateStart){
                
                finishDate = finishDate+date+" ";
                
            }
           
           return finishDate + " \n";

        }
       
  
        public int DurationOfProject(ProgrammerIncharge programmer){
            /*DateTime startDateOfProject=programmer.GetActivityDateStart();
            DateTime finishDateOfProject=programmer.GetActivityDateFinish();
            startDateOfProject=finishDateOfProject.AddHours(-1);
            
            TimeSpan ts = finishDateOfProject.Date.Subtract(startDateOfProject.Date) ;
            //Console.WriteLine(ts.TotalDays + " " + ts.TotalHours);  */
          return 0;//(float)ts.TotalDays;
        }
        public override string ToString()
        {
            return lastName+","+ " " + firtsName+"," + " in charge of " + activityProgrammerIncharge + " from " + activityDateStart + " to " + activityDateFinish
            +"(duration " + this.DurationOfProject(this) + ")," +" this month:" + " n11 days " + "(total cost = n12 $) " +"\n";
        }
        
      






    }
}
