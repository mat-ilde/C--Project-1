using System;
using EmployeeDetailsImplementation;
using ProjectTeamProgrammerInCharge;
using System.Collections.Generic; 


namespace MainClass{
   public class Program{
    
      static void Main(string[] args){
        
          ProgrammerIncharge Guillermo= new ProgrammerIncharge("Guillermo","Garcia");
          Guillermo.AddActivity("Working on IA");
          DateTime activityDateStartG = new DateTime(2015, 12, 20);
          DateTime activityDateFinishG = new DateTime(2016, 10, 20);
          Guillermo.AddActivityDateStart(activityDateStartG);
          Guillermo.AddActivityDateFinish(activityDateFinishG);

          ProgrammerIncharge William= new ProgrammerIncharge("William","Willis");
          William.AddActivity("Working on MetaVerso");
          DateTime activityDateStartW = new DateTime(2015, 12, 20);
          DateTime activityDateFinishW = new DateTime(2016, 10, 20);
          William.AddActivityDateStart(activityDateStartW);
          William.AddActivityDateFinish(activityDateFinishW);
          
          ProjectTeam projectTeam=new ProjectTeam();

          
          projectTeam.AddProjectTeam(Guillermo);
          projectTeam.AddProjectTeam(William);

          Guillermo.DurationOfProject(Guillermo);
          //William.DurationOfProject(William);
          Console.Write(projectTeam.ToString());

          
         

        
      }
    }
  }







