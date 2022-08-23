using System;
using EmployeeDetails;


namespace EmployeeDetailsImplementation{


  // class ProgrammerIncharge implementing the interface Employee
    public class ProgrammerIncharge: IEmployee {
        String? firtsNameProgrammerIncharge;
        String? lastNameProgrammerIncharge;
        String? activityProgrammerIncharge;
        String? activityDateStartProgrammerIncharge;
        String? activityDateFinishProgrammerIncharge;

        public ProgrammerIncharge(String firtsName, String lastName){
            firtsNameProgrammerIncharge=firtsName;
            lastNameProgrammerIncharge=lastName;

        }
    

        public void SetFirstName(String firtsName){
            firtsNameProgrammerIncharge=firtsName;

        }
        public void SetLastName(String lastName){
            lastNameProgrammerIncharge=lastName;

        }

        public void SetActivity(String activity){
            activityProgrammerIncharge=activity;


        }
        public void SetActivityDateStart(String activityDateStart){
            activityDateStartProgrammerIncharge=activityDateStart;

        }
        public void SetActivityDateFinish(String activityDateFinish){
            activityDateFinishProgrammerIncharge=activityDateFinish;

        }

        public void GetLastName(){
            Console.Write(lastNameProgrammerIncharge+ " ");

        }
        public void GetFirtsName(){
            Console.Write(firtsNameProgrammerIncharge +" ");

        }
        public void GetActivity(){
            Console.Write(activityProgrammerIncharge+ " ");

        }
        public void GetActivityDateStart(){
            Console.Write(activityDateFinishProgrammerIncharge+ " ");

        }
        public void GetActivityDateFinish(){
            Console.Write(activityDateFinishProgrammerIncharge+ " ");

        }



    }
}
