using EmployeeDetailsImplementation;
using ProjectTeamProgrammerInCharge;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Collections.Generic;





namespace MainClass
{
    public class ItCompany
    {
        List<ProjectTeam> listOfTeams = new List<ProjectTeam>();
        public void AddProjectTeam(ProjectTeam projectTeam)
        {
            listOfTeams.Add(projectTeam);
        }
        public void SystemStatusReport(){
            Console.Write("IT COMPANY-Report");
        }

        /*for(int i=0; i<listOfTeams.Count){

        }*/

        static void Main(string[] args)
        {
            
            ProgrammerIncharge Guillermo = new ProgrammerIncharge("Guillermo", "Garcia");
            Guillermo.SetActivity("Working on IA");
            Guillermo.SetActivityDateStart("2015-12-01");
            Guillermo.SetActivityDateFinish("2015-12-20");

            ProgrammerIncharge William = new ProgrammerIncharge("William", "Willis");
            William.SetActivity("Working on IA");
            William.SetActivityDateStart("2015-12-01");
            William.SetActivityDateFinish("2015-12-20");

            ProjectTeam projectTeamPartTime = new ProjectTeam(false);

            projectTeamPartTime.AddProgrammer(Guillermo);
            projectTeamPartTime.AddProgrammer(William);



            ProgrammerIncharge Mary = new ProgrammerIncharge("Mary", "Aldana");
            Mary.SetActivity("Working on Metaverse");
           // Mary.SetActivityDateStart("2014-10-01");
            //Mary.SetActivityDateFinish("2014-10-20");

            ProgrammerIncharge Amelia = new ProgrammerIncharge("Amelia", "Perez");
            Amelia.SetActivity("Working on Metaverse");
            //Amelia.SetActivityDateStart("2014-10-01");
            //Amelia.SetActivityDateFinish("2014-10-20");

            /*ProjectTeam projectTeamFullTime = new ProjectTeam(true);

            projectTeamFullTime.AddProgrammer(Mary);
            projectTeamFullTime.AddProgrammer(Amelia);*/

          
            

            //projectTeamFullTime.GetXmlFile(projectTeamFullTime, "projectTeamFullTime.xml");
            projectTeamPartTime.SaveSystem(projectTeamPartTime, "projectTeamPartTime.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load("projectTeamPartTime.xml");
            XmlNode topNode = doc.DocumentElement;
            ProjectTeam projectTeamFullTime= new ProjectTeam(topNode);
            //Console.Write(projectTeamFullTime.ToString());
            Console.Write( projectTeamFullTime.UpdateSystem());




            //projectTeamPartTime.ReadXMLFileUsingXMLDocument();
            //Console.Write(projectTeamPartTime.ReadXMLFileUsingXMLDocument("projectTeamPartTime.xml"));




            //Guillermo.DurationOfProject(Guillermo);
            //William.DurationOfProject();
            //Console.Write(projectTeamFullTime.ToString());
            //projectTeamFullTime.ToString();
        /*var mySerializer = new XmlSerializer(typeof(ProjectTeam));
        // To read the file, create a FileStream.
        using var myFileStream = new FileStream("projectTeamPartTime.xml", FileMode.Open);
        // Call the Deserialize method and cast to the object type.
        var myObject = (ProjectTeam)mySerializer.Deserialize(myFileStream);*/







        }
    }
}







