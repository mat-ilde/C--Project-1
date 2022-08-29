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
            Console.Write("Layout:" + "\n" + "\n");
            Console.Write("IT COMPANY-Report" + "\n" + "\n");

            string currentMonthNumber = DateTime.Now.ToString("MMMM");
            DateTime currentMonth = DateTime.Now;
            string day = currentMonth.Day.ToString();
            int totalDaysOfTheMonth = DateTime.DaysInMonth(2022, 8);
            int daysToInt = Convert.ToInt32(day);
            int daysConsumedByProgrammers = totalDaysOfTheMonth - daysToInt;

            int numberOfProjectTeams = 0;
            int numberOfProgrammerInChargeByTeam = 0;
            int numberOfProgrammerInChargeInTotal = 0;
            foreach (ProjectTeam team in listOfTeams)
            {
                numberOfProjectTeams = listOfTeams.Count;
                numberOfProgrammerInChargeByTeam = team.GetListOfProgrammerInCharge().Count;

                foreach (ProgrammerIncharge programmer in team.GetListOfProgrammerInCharge())
                {
                    numberOfProgrammerInChargeInTotal = numberOfProgrammerInChargeInTotal + 1;
                }

            }

            Console.Write("IT company is actually composed of " + numberOfProjectTeams + " project teams," + " and " + numberOfProgrammerInChargeByTeam +
            " programmers." + "\n" + "this month" + " " + currentMonthNumber + "," + " " + day + " days " + "has been consumed by "
            + numberOfProgrammerInChargeInTotal + " programmers," + " " + "and " + daysConsumedByProgrammers + " still in charge" + "\n" + "\n");

            Console.Write("Project teams details" + "\n" + "\n");
            foreach (ProjectTeam team in listOfTeams)
            {
                if (team.fullTime == true)
                {
                    Console.Write(" FullTime project Team:" + "\n");
                    Console.Write(team + "\n");
                }
                else
                {
                    Console.Write(" PartTime project Team:" + "\n");
                    Console.Write(team + "\n");
                }
            }
        }

        static void Main(string[] args)
        {
            //creating the programmer in charge
            ProgrammerIncharge Guillermo = new ProgrammerIncharge("Guillermo", "Garcia");
            Guillermo.SetActivity("Working on IA");
            Guillermo.SetActivityDateStart("2015-02-01");
            Guillermo.SetActivityDateFinish("2015-02-20");

            ProgrammerIncharge William = new ProgrammerIncharge("William", "Willis");
            William.SetActivity("Working on IA");
            William.SetActivityDateStart("2015-02-01");
            William.SetActivityDateFinish("2015-02-20");

            //creating the project team
            ProjectTeam projectTeamPartTime = new ProjectTeam(false, 12);

            //adding programmers to the team
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

            ProjectTeam projectTeamFullTime = new ProjectTeam(true, 24);

            projectTeamFullTime.AddProgrammer(Mary);
            projectTeamFullTime.AddProgrammer(Amelia);

            //TO SAVE THE DATA INTO A XML FILE
            projectTeamFullTime.SaveSystem(projectTeamFullTime, "projectTeamFullTime.xml");
            projectTeamPartTime.SaveSystem(projectTeamPartTime, "projectTeamPartTime.xml");


            // TO CREATE OBJECTS FROM THE XML FILE USING NODES
            /*XmlDocument docFull = new XmlDocument();
            docFull.Load("projectTeamFullTime.xml");
            XmlNode topNodeFullTime = docFull.DocumentElement;
            ProjectTeam projectTeamFullTimeFromXml = new ProjectTeam(topNodeFullTime);
            
    
            XmlDocument docPart = new XmlDocument();
            docPart.Load("projectTeamPartTime.xml");
            XmlNode topNodePartTime = docPart.DocumentElement;
            ProjectTeam projectTeamPartTimeFromXml = new ProjectTeam(topNodePartTime);*/

            //TO CREATE AN INSTANCE to THE ITCOMPANY
            ItCompany itCompany = new ItCompany();

            //TO ADD TEAMS TO THE ITCOMPANY CLASS
            itCompany.AddProjectTeam(projectTeamFullTime);
            itCompany.AddProjectTeam(projectTeamPartTime);

            //TO SEE THE REPORT STATUS
            itCompany.SystemStatusReport();

            //TO GET UPDATE THE DATE
            //projectTeamFullTime.UpdateSystem();
        }
    }
}







