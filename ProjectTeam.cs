using System;
using EmployeeDetailsImplementation;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.Serialization;


namespace ProjectTeamProgrammerInCharge
{


    // class ProgrammerIncharge implementing the interface Employee

    [XmlRoot(ElementName = "ProjectTeam")]
    public class ProjectTeam
    {
        [XmlElement(
            ElementName = "Members")]
        public List<ProgrammerIncharge> listOfProgrammersInCharge = new List<ProgrammerIncharge>();
        [XmlElement(
            ElementName = "FullTime")]
        public bool fullTime;
        [XmlElement(
           ElementName = "Cost")]
        public int cost;

        public int GetCost()
        {
            return this.cost;
        }

        public void SetCost(int cost)
        {
            this.cost = cost;
        }
        //full-time or part-time
        public void SetTypeofJob(Boolean fullTime)
        {
            this.fullTime = fullTime;
        }
        public Boolean GetTypeofJob()
        {
            return this.fullTime;
        }

        public ProjectTeam()
        {

        }

        public ProjectTeam(bool fullTime, int cost)
        {
            this.fullTime = fullTime;
            this.cost = cost;

        }
        //load function as constructor return ProjectTeam from xml file
        public ProjectTeam(XmlNode rootNode)
        {
            String typeOfJobString = rootNode.SelectSingleNode("FullTime").InnerText;
            bool typeOfJobBool = bool.Parse(typeOfJobString);


            if (typeOfJobBool == true)
            {
                this.SetTypeofJob(true);

            }
            else
            {
                this.SetTypeofJob(false);

            }
            XmlNodeList xnList = rootNode.SelectNodes("/ProjectTeam/Members");


            foreach (XmlNode programmerNode in xnList)
            {
                ProgrammerIncharge programmer = new ProgrammerIncharge(programmerNode);
                this.AddProgrammer(programmer);
            }
        }
        public void AddProgrammer(ProgrammerIncharge programmer)
        {

            listOfProgrammersInCharge.Add(programmer);

        }

        public override string ToString()
        {
            String projectTeamString = "";

            foreach (ProgrammerIncharge programmer in listOfProgrammersInCharge)
            {

                String programmerString = programmer.ToString();
                projectTeamString = projectTeamString + programmerString;

            }
            return projectTeamString + " Fulltime Team : " + GetTypeofJob()
            + " (total cost= " + GetCost() + " $)" + "\n";
        }

        public List<ProgrammerIncharge> GetListOfProgrammerInCharge()
        {
            return listOfProgrammersInCharge;
        }

        public void SaveSystem(ProjectTeam team, String fileName)
        {
            var serializer = new XmlSerializer(typeof(ProjectTeam));
            using (var writer = new StreamWriter(fileName))
            {

                serializer.Serialize(writer, team);
            }

        }
        //TO GET THE PROJECT DATE UPDATE
        public void UpdateSystem()
        {
            TimeSpan totalOfDays = TimeSpan.Zero;
            foreach (ProgrammerIncharge programmer in listOfProgrammersInCharge)
            {
                DateTime dateUpdate = programmer.GetActivityDateFinish().AddDays(1);
                String dateUpdateString = dateUpdate.ToString();
                programmer.SetActivityDateFinish(dateUpdateString);
                Console.Write(dateUpdateString);
            }

        }


    }

}



