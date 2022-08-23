using System;
using EmployeeDetailsImplementation;
using ProjectTeamProgrammerInCharge;

namespace MainClass{
   class Program 
  {
    static void Main(string[] args) 

    {
        ProgrammerIncharge p= new ProgrammerIncharge("Maria","Perez");
        ProgrammerIncharge g= new ProgrammerIncharge("Mario","Pereza");

        ProjectTeam projectTeam=new ProjectTeam();
        //p.GetFirtsName();
        //p.GetLastName();
        projectTeam.SetProjectTeam(p);
        projectTeam.SetProjectTeam(g);

        projectTeam.GetProjecTeam();
       
      
    }
  }
}



