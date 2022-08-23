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
    public void SetActivityDateStart(String activityDateStart);
    public void SetActivityDateFinish(String activityDateFinish);

    public void GetLastName();
    public void GetFirtsName();
    public void GetActivity();
    public void GetActivityDateStart();
    public void GetActivityDateFinish();




  }

}