using System;
using EmployeeDetails;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Xml;



namespace EmployeeDetailsImplementation
{



    [XmlRoot(ElementName = "ProgrammerIncharge")]
    // class ProgrammerIncharge implementing the interface Employee
    public class ProgrammerIncharge : IEmployee
    {
        public String firtsName;
        public String lastName;

        public String activityProgrammerIncharge;

        [XmlIgnore]
        public DateTime activityDateStart = new DateTime();

        [XmlIgnore]
        public DateTime activityDateFinish = new DateTime();

        public ProgrammerIncharge()
        {

        }

        public ProgrammerIncharge(String firtsName, String lastName)
        {
            this.firtsName = firtsName;
            this.lastName = lastName;

        }
        //load function as constructor
        public ProgrammerIncharge(XmlNode node)
        {
            string firtsName = node.SelectSingleNode("firtsName").InnerText;
            string lastName = node.SelectSingleNode("lastName").InnerText;
            this.SetFirstName(firtsName);
            this.SetLastName(lastName);
            //using try catch in case the date doesn't exist
            try
            {
                XmlNodeList activityDateStart = node.SelectNodes("activityDateStart");
                foreach (XmlNode dateStartNode in activityDateStart)
                {
                    String date = dateStartNode.InnerText;
                    this.SetActivityDateStart(date);
                }

            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            try
            {

                XmlNodeList activityDateFinish = node.SelectNodes("activityDateFinish");
                foreach (XmlNode dateFinishNode in activityDateFinish)
                {

                    String date = dateFinishNode.InnerText;
                    this.SetActivityDateFinish(date);
                }

            }
            catch (Exception ex)
            {
                Console.Write(ex);

            }
            string activity = node.SelectSingleNode("activityProgrammerIncharge").InnerText;
            this.SetActivity(activity);
        }

        public void SetFirstName(String firtsName)
        {
            this.firtsName = firtsName;

        }
        public void SetLastName(String lastName)
        {
            this.lastName = lastName;

        }
        public void SetActivity(String activity)
        {
            this.activityProgrammerIncharge = activity;

        }
        public void SetActivityDateStart(String date)
        {

            this.activityDateStart = DateTime.Parse(date);
            this.activityDateStart = this.activityDateStart.Date;
        }
        public void SetActivityDateFinish(String date)
        {

            this.activityDateFinish = DateTime.Parse(date);
            this.activityDateFinish = activityDateFinish.Date;
        }

        public String GetLastName()
        {
            return lastName;

        }
        public String GetFirtsName()
        {
            return firtsName;

        }

        [XmlElement("activityDateStart")]
        public string activityDateStartString
        {
            get { return this.activityDateStart.ToString("d"); }
            set { this.activityDateStart = activityDateStart.Date; }

        }

        [XmlElement("activityDateFinish")]
        public string activityDateFinishString
        {
            get { return this.activityDateFinish.ToString("d"); }
            set { this.activityDateFinish = activityDateStart.Date; }
        }

        public String GetActivity()
        {
            return activityProgrammerIncharge;

        }

        public DateTime GetActivityDateStart()
        {
            //Console.Write(this.activityDateStart.ToString("d MMM yyyy") + "\n");
            return this.activityDateStart.Date;

        }
        public DateTime GetActivityDateFinish()
        {
            return this.activityDateFinish.Date;

        }

        public double GetDurationOfProject()
        {
            double intervalDays = 0;
            DateTime startDateProject = GetActivityDateStart();
            DateTime finishDateProject = GetActivityDateFinish();
            TimeSpan totalOfDays = finishDateProject - startDateProject;
            intervalDays = totalOfDays.Days;

            return intervalDays;
        }

        public override string ToString()

        {
            int restOfDaysOfFinihProjectMonth = DateTime.DaysInMonth(2022, 8);

            return GetLastName() + "," + " " + GetFirtsName() + "," + " in charge of " + GetActivity() + " from " + GetActivityDateStart().ToShortDateString() + " to " + GetActivityDateFinish().ToShortDateString()
            + " (duration = " + GetDurationOfProject() + " days " + ")," + " this month = " + restOfDaysOfFinihProjectMonth + " days " + "\n";
        }
        public void SaveSystem(ProgrammerIncharge programmer, String fileName)
        {

            var serializer = new XmlSerializer(typeof(ProgrammerIncharge));
            using (var writer = new StreamWriter(fileName))
            {

                serializer.Serialize(writer, programmer);
            }
        }


    }
}
