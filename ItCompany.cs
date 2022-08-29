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
        public void SystemStatusReport()
        {
            Console.Write("Layout:" + "\n" +"\n");
            Console.Write("IT COMPANY-Report" + "\n"+ "\n");

            string currentMonthNumber = DateTime.Now.ToString("MMMM");
            string projectStartMonthNameString = "";

            double durationOfProject = 0;

            int numberOfProjectTeams = 0;
            int numberOfProgrammerInChargeByTeam = 0;
            int numberOfProgrammerInChargeInTotal = 0;
            int projectMonthToInt = 0;
            int i;
            double restOFday=0;
            DateTime finishDateProject;
            string projectFinishMonthStringName="";
            int yearFinishproject;
            int restOfDaysOfFinihProjectMonth=0;
            int durationOfProjectToInt = Convert.ToInt32(durationOfProject);
            for (i = 0; i < listOfTeams.Count; i++)
            {
                numberOfProjectTeams = listOfTeams.Count;
                numberOfProgrammerInChargeByTeam = listOfTeams[i].GetListOfProgrammerInCharge().Count;

                foreach (ProgrammerIncharge programmer in listOfTeams[i].GetListOfProgrammerInCharge())
                {
                    projectFinishMonthStringName = programmer.GetActivityDateFinish().ToString("MM");
                    projectMonthToInt = Int32.Parse(projectFinishMonthStringName);
                    finishDateProject = programmer.GetActivityDateFinish();
                    yearFinishproject=finishDateProject.Year;
                    restOfDaysOfFinihProjectMonth = DateTime.DaysInMonth(yearFinishproject, projectMonthToInt);

                   
                    durationOfProject = programmer.GetDurationOfProject();
                    projectStartMonthNameString=programmer.GetActivityDateStart().ToString("MM");
                    durationOfProjectToInt = Convert.ToInt32(durationOfProject);
                    restOFday=restOfDaysOfFinihProjectMonth-durationOfProjectToInt;

                }

            }
            
            numberOfProgrammerInChargeInTotal = numberOfProgrammerInChargeByTeam + i;


            Console.Write("IT company is actually composed of " + numberOfProjectTeams + " project teams," + " and " + numberOfProgrammerInChargeByTeam +
            " programmers." +"\n" + "this month" + " " + currentMonthNumber + "," + " " + durationOfProject + " days " + "has been consumed by "
            + numberOfProgrammerInChargeInTotal + " programmers," + " " + "and " + restOFday + " still in charge" + "\n"+ "\n");
            
            Console.Write("Project teams details"+"\n"+"\n");

            foreach(ProjectTeam team  in listOfTeams){
                
                if (team.fullTime==true){
                    Console.Write(" FullTime project Team:" + "\n");
                    Console.Write(team + "\n");
                }else{
                    Console.Write(" PartTime project Team:" + "\n");
                    Console.Write(team + "\n");
                }
                
               
            }



        }


        static void Main(string[] args)
        {

            ProgrammerIncharge Guillermo = new ProgrammerIncharge("Guillermo", "Garcia");
            Guillermo.SetActivity("Working on IA");
            Guillermo.SetActivityDateStart("2015-02-01");
            Guillermo.SetActivityDateFinish("2015-02-20");

            ProgrammerIncharge William = new ProgrammerIncharge("William", "Willis");
            William.SetActivity("Working on IA");
            William.SetActivityDateStart("2015-02-01");
            William.SetActivityDateFinish("2015-02-20");

            ProjectTeam projectTeamPartTime = new ProjectTeam(false, 12);

            projectTeamPartTime.AddProgrammer(Guillermo);
            projectTeamPartTime.AddProgrammer(William);


            ProgrammerIncharge Mary = new ProgrammerIncharge("Mary", "Aldana");
            Mary.SetActivity("Working on Metaverse");
            Mary.SetActivityDateStart("2014-10-01");
            Mary.SetActivityDateFinish("2014-10-20");

            ProgrammerIncharge Amelia = new ProgrammerIncharge("Amelia", "Perez");
            Amelia.SetActivity("Working on Metaverse");
            Amelia.SetActivityDateStart("2014-10-01");
            Amelia.SetActivityDateFinish("2014-10-20");

            ProjectTeam projectTeamFullTime = new ProjectTeam(true,24);

            projectTeamFullTime.AddProgrammer(Mary);
            projectTeamFullTime.AddProgrammer(Amelia);

           

            /*projectTeamFullTime.SaveSystem(projectTeamFullTime, "projectTeamFullTime.xml");
            projectTeamPartTime.SaveSystem(projectTeamPartTime, "projectTeamPartTime.xml");*/


            // to create load the system from a xml and create objects
            /*XmlDocument docFull = new XmlDocument();
            docFull.Load("projectTeamFullTime.xml");
            XmlNode topNodeFullTime = docFull.DocumentElement;
            ProjectTeam projectTeamFullTimeFromXml = new ProjectTeam(topNodeFullTime);
            
    
            XmlDocument docPart = new XmlDocument();
            docPart.Load("projectTeamPartTime.xml");
            XmlNode topNodePartTime = docPart.DocumentElement;
            ProjectTeam projectTeamPartTimeFromXml = new ProjectTeam(topNodePartTime);*/


            ItCompany itCompany = new ItCompany();

            itCompany.AddProjectTeam(projectTeamFullTime);
            itCompany.AddProjectTeam(projectTeamPartTime);

            itCompany.SystemStatusReport();





        }
    }
}







