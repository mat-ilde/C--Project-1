using System;
using EmployeeDetailsImplementation;
using System.Collections.Generic; 


namespace ProjectTeamProgrammerInCharge{


  // class ProgrammerIncharge implementing the interface Employee
    public class ProjectTeam{

        private List<ProgrammerIncharge> listOfProgrammersInCharge=new List<ProgrammerIncharge>();
        private Boolean fullTime;

        public ProjectTeam(Boolean fullTime){
            this.fullTime=fullTime;
            
        }

        public void AddProgrammer(ProgrammerIncharge programmer ){
            
            listOfProgrammersInCharge.Add(programmer);

        }
         
        public override string ToString() { 
            String projectTeamString="";
            
            foreach(ProgrammerIncharge programmer in listOfProgrammersInCharge){
                
                String programmerString=programmer.ToString();
                projectTeamString=projectTeamString+programmerString;
                
            }
            return projectTeamString +"fulltime Team:";
        }
        
        public  List<ProgrammerIncharge> GetListOfProgrammerInCharge (){
            return listOfProgrammersInCharge;
        }
        public void AddTypeofJob(Boolean typeOfJob){
            this.fullTime=typeOfJob;
        }
        public Boolean GetTypeofJob(){
            return fullTime;
        }
      
        public void GetProjecTeam(){
            foreach(ProgrammerIncharge programmer in listOfProgrammersInCharge){
              Console.Write(programmer);
            }
          
        
        }
    }   

}
