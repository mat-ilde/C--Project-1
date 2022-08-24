using System;

namespace EmployeeDetails
{
  // Interface
  public interface IEmployee
  {

    //assigning lastname
    void AddLastName(String lastName);
    //assigning firtsname
    public void AddFirstName(String firtsName);
    public void AddActivity(String activity);
    public void AddActivityDateStart(DateTime activityDateStart);
    public void AddActivityDateFinish(DateTime activityDateFinish);

    public String GetLastName();
    public String GetFirtsName();
    public String GetActivity();
    public DateTime GetActivityDateStart();
    public DateTime GetActivityDateFinish();

  }

}