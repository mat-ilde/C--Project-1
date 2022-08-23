using System;
using EmployeeDetailsImplementation;
using ProjectTeamProgrammerInCharge;
using System.Collections.Generic; 


namespace MainClass{
   public class Program{
    
      static void Main(string[] args){
        
          ProgrammerIncharge Guillermo= new ProgrammerIncharge("Guillermo","Garcia");
          Guillermo.SetActivity("Working on IA");
          DateTime activityDateStartG = new DateTime(2015, 12, 20);
          DateTime activityDateFinishG = new DateTime(2016, 10, 20);
          Guillermo.SetActivityDateStart(activityDateStartG);
          Guillermo.SetActivityDateFinish(activityDateFinishG);

          ProgrammerIncharge William= new ProgrammerIncharge("William","Willis");
          William.SetActivity("Working on MetaVerso");
          DateTime activityDateStartW = new DateTime(2015, 12, 20);
          DateTime activityDateFinishW = new DateTime(2016, 10, 20);
          William.SetActivityDateStart(activityDateStartW);
          William.SetActivityDateFinish(activityDateFinishW);
          
          ProjectTeam projectTeam=new ProjectTeam();

          
          projectTeam.SetProjectTeam(Guillermo);
          projectTeam.SetProjectTeam(William);

          Guillermo.DurationOfProject(Guillermo);
          //William.DurationOfProject(William);
          projectTeam.GetProjecTeam();

          
         

        
      }
    }
  }







