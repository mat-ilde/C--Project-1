using System;
using EmployeeDetailsImplementation;
using System.Collections.Generic; 
using System.IO;
using System.Xml.Serialization;
using System.Xml;


namespace ProjectTeamProgrammerInCharge{


  // class ProgrammerIncharge implementing the interface Employee
  [XmlRoot(ElementName = "ProjectTeam")]

    public class ProjectTeam{

       [XmlElement(
            ElementName = "Members")]
        public List<ProgrammerIncharge> listOfProgrammersInCharge=new List<ProgrammerIncharge>();
        public Boolean fullTime;

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
         public void GetXmlFile(ProjectTeam team, String fileName){

            var serializer = new XmlSerializer(typeof(ProjectTeam));
            using (var writer = new StreamWriter(fileName)){
        
                serializer.Serialize(writer, team);
            }
        }
        public void ReadXMLFileUsingXMLDocument()
        {
            XmlDocument xmlDcoument = new XmlDocument();
            xmlDcoument.Load(@"projectTeamPartTime.xml");
            var navigator = xmlDcoument.CreateNavigator();
            var expr = navigator.Compile("/ProjectTeam/Members/(activityDateStart");
            var count = navigator.Evaluate(expr); // 3 (nodes)

            XmlNodeList xmlNodeList = xmlDcoument.DocumentElement.SelectNodes("/ProjectTeam/Members");
            XmlNodeList xmlNodeListp = xmlDcoument.DocumentElement.SelectNodes("/ProjectTeam/Members/activityDateStart");
            Console.WriteLine("Output using XMLDocument");
            foreach (XmlNode xmlNode in xmlNodeListp)
            {
                Console.WriteLine("Id of the Employee is : " + xmlNode.SelectSingleNode("firtsName").InnerText);
                Console.WriteLine("Name of the Employee is : " + xmlNode.SelectSingleNode("lastName").InnerText);
                Console.WriteLine("Id of the Employee is : " + xmlNode.SelectSingleNode("activityDateStart").InnerText);
                //Console.WriteLine("Name of the Employee is : " + xmlNode.SelectSingleNode("lastName").InnerText);
                Console.WriteLine();
            }
        }
    }   

}
