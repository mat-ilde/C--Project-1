using System;

namespace EmployeeDetails
{
  // Interface
  public interface IEmployee
  {

    //assigning lastname
    public void AddLastName(String lastName);
    //assigning firtsname
    public void AddFirstName(String firtsName);
    public void AddActivity(String activity);
    
    public void AddActivityDateStart(String year, String month, String day);
    public void AddActivityDateFinish(String year, String month, String day);

    public String GetLastName();
    public String GetFirtsName();
    public String GetActivity();
    public String GetActivityDateStart();
    public String GetActivityDateFinish();

  }

}