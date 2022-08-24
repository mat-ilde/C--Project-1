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

        }
        public void AddActivityDateFinish(String year, String month, String day)
        {   
             
            this.activityDateFinish.Add(year);
            this.activityDateFinish.Add(month);
            this.activityDateFinish.Add(day);

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
                
                startDate = startDate+date+"/";
                
            }
           
           return startDate + " ";

        }
        public String GetActivityDateFinish()
        {
            String finishDate="";            
            foreach(String date in activityDateFinish){
                
                finishDate = finishDate+date+"/ ";
                
            }
           
           return finishDate + " ";

        }
       
  
        public int GetDurationOfProject(){

            String startDateProject=GetActivityDateStart();
            String finishDateProject=GetActivityDateFinish();
            String startDayProject="";
            String finishDayProject="";

            string[] startDates = startDateProject.Split(new[] { "/" }, StringSplitOptions.None);
            startDayProject=startDates[2];
            string[] FinishDates = finishDateProject.Split(new[] { "/" }, StringSplitOptions.None);
            finishDayProject=FinishDates[2];


            int startDayToInt = Int32.Parse(startDayProject);
            int finishDayToInt = Int32.Parse(finishDayProject);

            int nDaysOfTheProject=finishDayToInt-startDayToInt;


          return nDaysOfTheProject;
        }
        public override string ToString()
        {   
            //from 1/07/2022 to 21/7/2022  (duration = 21 days) this month=31 days

            return GetLastName() +","+ " " + GetFirtsName() +"," + " in charge of " + GetActivity() + " from " + GetActivityDateStart() + " to " + GetActivityDateFinish()
            +"(duration = " + GetDurationOfProject() + " days " + ")," + " this month = 31 days  "  + "(total cost = n12 $) " +"\n";
        }
        
      
    





    }
}
