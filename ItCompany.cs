using System;
using EmployeeDetailsImplementation;
using ProjectTeamProgrammerInCharge;
using System.Collections.Generic; 
using System.Xml.Serialization;  
using System.IO;  
using System.Xml;




namespace MainClass{
   public class ItCompany{

    
    
      static void Main(string[] args){

        
        ProgrammerIncharge Guillermo= new ProgrammerIncharge("Guillermo","Garcia");
        Guillermo.AddActivity("Working on IA");
        Guillermo.AddActivityDateStart("2015","12","1");
        Guillermo.AddActivityDateFinish("2015","12","20");

        ProgrammerIncharge William= new ProgrammerIncharge("William","Willis");
        William.AddActivity("Working on IA");
        William.AddActivityDateStart("2015","12","1");
        William.AddActivityDateFinish("2015","12","20");

        ProjectTeam projectTeamPartTime=new ProjectTeam(false);
        
        projectTeamPartTime.AddProgrammer(Guillermo);
        projectTeamPartTime.AddProgrammer(William);
        

        
        ProgrammerIncharge Mary= new ProgrammerIncharge("Mary","Aldana");
        Mary.AddActivity("Working on Metaverse");
        Mary.AddActivityDateStart("2014","10","1");
        Mary.AddActivityDateFinish("2014","10","20");
        
        ProgrammerIncharge Amelia= new ProgrammerIncharge("Amelia","Perez");
        Amelia.AddActivity("Working on Metaverse");
        Amelia.AddActivityDateStart("2014","10","1");
        Amelia.AddActivityDateFinish("2014","10","20");

        ProjectTeam projectTeamFullTime=new ProjectTeam(true);
        
        projectTeamFullTime.AddProgrammer(Mary);
        projectTeamFullTime.AddProgrammer(Amelia);
        
        /*projectTeamFullTime.GetXmlFile(projectTeamFullTime, "projectTeamFullTime.xml");
        projectTeamPartTime.GetXmlFile(projectTeamPartTime, "projectTeamPartTime.xml");*/

        projectTeamPartTime.ReadXMLFileUsingXMLDocument();
        //Console.Write(z);



       


        //Guillermo.DurationOfProject(Guillermo);
        //William.DurationOfProject();
        //Console.Write(projectTeamFullTime.ToString());
        //projectTeamFullTime.ToString();
        
       
        

      
         

        
      }
    }
  }







