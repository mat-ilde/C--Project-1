using System;
using EmployeeDetailsImplementation;
using System.Collections.Generic; 
using System.IO;
using System.Xml.Serialization;
using System.Xml;


namespace ProjectTeamProgrammerInCharge{


  // class ProgrammerIncharge implementing the interface Employee
    public class ProjectTeam{

       [XmlElement(
            ElementName = "Members")]
        public List<ProgrammerIncharge> listOfProgrammersInCharge=new List<ProgrammerIncharge>();
        private Boolean fullTime;

        public ProjectTeam(){
           
        }

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
            return projectTeamString + " fulltime Team : " + GetTypeofJob() +" ";
        }
        
        public  List<ProgrammerIncharge> GetListOfProgrammerInCharge (){
            return listOfProgrammersInCharge;
        }
        //fulltime or part-time
        public void AddTypeofJob(Boolean typeOfJob){
            this.fullTime=typeOfJob;
        }
        public Boolean GetTypeofJob(){
            return fullTime ;
        }
      
        public void GetProjecTeam(){
            foreach(ProgrammerIncharge programmer in listOfProgrammersInCharge){
              Console.Write(programmer);
            }
          
        
        }
         public void GetSerialization(ProjectTeam team, String fileName){

            var serializer = new XmlSerializer(typeof(ProjectTeam));
            using (var writer = new StreamWriter(fileName)){
        
                serializer.Serialize(writer, team);
            }
        }
    }   

}
