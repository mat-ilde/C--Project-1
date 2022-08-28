using System;

namespace EmployeeDetails
{
  // Interface
  public interface IEmployee
  {

    //assigning lastname
    public void SetLastName(String lastName);
    //assigning fitsname
    public void SetFirstName(String firtsName);
    public void SetActivity(String activity);
    
    public void SetActivityDateStart(String date);
    public void SetActivityDateFinish(String date);

    public String GetLastName();
    public String GetFirtsName();
    public String GetActivity();
    public DateTime GetActivityDateStart();
    public DateTime GetActivityDateFinish();

  }

}