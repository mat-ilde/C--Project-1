using System;
using EmployeeDetailsImplementation;
using System.Collections.Generic; 


namespace ProjectTeamProgrammerInCharge{


  // class ProgrammerIncharge implementing the interface Employee
    public class ProjectTeam{

        private List<ProgrammerIncharge> listOfProgrammersInCharge=new List<ProgrammerIncharge>();
        private Boolean fullTime{set;get;}

        public ProjectTeam()
        {
            
        }

        public void AddProjectTeam(ProgrammerIncharge programmer ){
            
            listOfProgrammersInCharge.Add(programmer);

        }
         
        public override string ToString() { 
            String projectTeamString="";
            
            
            foreach(ProgrammerIncharge programmer in listOfProgrammersInCharge){
                
                String programmerString=programmer.ToString();
                projectTeamString=projectTeamString+programmerString;

                
                /*return programmer.GetLastName() +","+ " " + programmer.GetFirtsName()+"," + " in charge of " + programmer.GetActivity() + 
                " from " + programmer.GetActivityDateStart() + " to " + programmer.GetActivityDateFinish()
                +"(duration)"  + " this month:" + " n11 days " + "(total cost = n12 $) " +"\n";*/
                
            }
            return projectTeamString +" ";
       
           
        }

        
        public void GetProjecTeam(){
          foreach(ProgrammerIncharge programmer in listOfProgrammersInCharge){
              Console.Write(programmer);
          }
          
        
        }
    }   

}
