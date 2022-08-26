using System;
using EmployeeDetailsImplementation;
using System.Collections.Generic; 
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;


namespace ProjectTeamProgrammerInCharge{


  // class ProgrammerIncharge implementing the interface Employee
  [XmlRoot(ElementName = "ProjectTeam")]

    public class ProjectTeam{

       [XmlElement(
            ElementName = "Members")]
        public List<ProgrammerIncharge> listOfProgrammersInCharge=new List<ProgrammerIncharge>();
       [XmlElement(
            ElementName = "FullTime")]
        
        public bool fullTime;


        public bool getFullTime()
        {
            return this.fullTime;
        }

        public void AddFullTime(bool fullTime)
        {
            this.fullTime = fullTime;
        }
        

        public ProjectTeam(){
           
        }

        public ProjectTeam(bool fullTime){
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
        public static T ConvertNode<T>(XmlNode node) where T: class
        {
            MemoryStream stm = new MemoryStream();

            StreamWriter stw = new StreamWriter(stm);
            stw.Write(node.OuterXml);
            stw.Flush();

            stm.Position = 0;

            XmlSerializer ser = new XmlSerializer(typeof(T));
            T result = (ser.Deserialize(stm) as T);

            return result;
        }

        public void ReadXMLFileUsingXMLDocument()
        {   
            //bool result = false;
            /*XDocument xmlDcoument = new XmlDocument();
            xmlDcoument.Load(@"projectTeamPartTime.xml");
            XmlNodeList xmlNodeList = xmlDcoument.DocumentElement.SelectNodes("/ProjectTeam/Members/FullTime");

            Console.WriteLine("Output using XMLDocument");
            XmlNodeList xmlNodeL = xmlDcoument.DocumentElement.SelectNodes("/ProjectTeam/Members/FullTime");*/

            


            /*foreach (XmlNode node in  xmlDcoument.DocumentElement.ChildNodes)
            {
                
                if (node.HasChildNodes ){
                    
                         
                    for (int i = 0; i <= node.ChildNodes.Count; i++){
                    
                        
                        Console.WriteLine(node.ChildNodes[i].Name + " : " + node.ChildNodes[i].InnerText);
                        
                    }
                    
                   

                }
               
               
            }*/
        }
    }
            

            /*foreach (XmlNode node in xmlDcoument.DocumentElement.ChildNodes){
                if (node.HasChildNodes){
                    for (int i = 0; i < node.ChildNodes.Count; i++)
                    {
                        //Console.WriteLine(node.ChildNodes[i].Name + " : " + node.ChildNodes[i].InnerText);
                       Console.WriteLine(node.ChildNodes[i]);
                    }
                }
            }*/
            //return team;
}
     


