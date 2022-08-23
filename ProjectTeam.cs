using System;
using EmployeeDetailsImplementation;
using System.Collections.Generic; 


namespace ProjectTeamProgrammerInCharge{


  // class ProgrammerIncharge implementing the interface Employee
    public class ProjectTeam{

        private List<ProgrammerIncharge> listOfProgrammersInCharge=new List<ProgrammerIncharge>();
        private ProgrammerIncharge programmer {set;get;}
        private Boolean fullTime{set;get;}

        public ProjectTeam()
        {
            
        }

        public void SetProjectTeam(ProgrammerIncharge programmer ){
            this.programmer=programmer;
            
            listOfProgrammersInCharge.Add(programmer);

        }
         public override string ToString()
        {
            return this.programmer.GetLastName() +","+ " " + this.programmer.GetFirtsName()+"," + " in charge of " + this.programmer.GetActivity() + 
            " from " + this.programmer.GetActivityDateStart() + " to " + this.programmer.GetActivityDateFinish()
            +"(duration n10,)" + " this month:" + " n11 days " + "(total cost = n12 $) " +"\n";
        }

        
        public void GetProjecTeam(){
          foreach(ProgrammerIncharge programmer in listOfProgrammersInCharge){
              Console.Write(programmer);
          }
          
        
        }
        public int DurationOfProject(ProgrammerIncharge programmer){
            DateTime now = DateTime.Now;
            DateTime then = DateTime.Now.AddDays(-7);
    
            
            programmer.GetActivityDateFinish();
            programmer.GetActivityDateStart().AddDays(-7);
            TimeSpan ts = programmer.GetActivityDateFinish() - programmer.GetActivityDateStart().AddDays(-7); 
            Console.WriteLine(ts);  
          return 0;
        }
      }

}
