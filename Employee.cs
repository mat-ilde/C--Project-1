using System;

namespace EmployeeDetails
{
  // Interface
  public interface IEmployee
  {

    //assigning lastname
    void SetLastName(String lastName);
    //assigning firtsname
    public void SetFirstName(String firtsName);
    public void SetActivity(String activity);
    public void SetActivityDateStart(DateTime activityDateStart);
    public void SetActivityDateFinish(DateTime activityDateFinish);

    public String GetLastName();
    public String GetFirtsName();
    public String GetActivity();
    public DateTime GetActivityDateStart();
    public DateTime GetActivityDateFinish();

  }

}