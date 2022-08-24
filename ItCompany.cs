using System;
using EmployeeDetailsImplementation;
using ProjectTeamProgrammerInCharge;
using System.Collections.Generic; 


namespace MainClass{
   public class Program{
    
      static void Main(string[] args){
        
        ProgrammerIncharge Guillermo= new ProgrammerIncharge("Guillermo","Garcia");
        Guillermo.AddActivity("Working on IA");
        Guillermo.AddActivityDateStart("2015","12","20");
        Guillermo.AddActivityDateFinish("2016","10","20");

        ProgrammerIncharge William= new ProgrammerIncharge("William","Willis");
        William.AddActivity("Working on MetaVerso");
        William.AddActivityDateStart("2015","12","20");
        William.AddActivityDateFinish("2016","10","20");


        
        ProjectTeam projectTeamFullTime=new ProjectTeam(true);

        
        projectTeamFullTime.AddProgrammer(Guillermo);
        projectTeamFullTime.AddProgrammer(William);

        Guillermo.DurationOfProject(Guillermo);
        //William.DurationOfProject(William);
        Console.Write(William.GetActivityDateStart());

          
         

        
      }
    }
  }







