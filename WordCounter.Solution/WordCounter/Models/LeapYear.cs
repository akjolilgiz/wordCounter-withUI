using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using LeapYear.Models;

namespace LeapYear.Models
{
  public class LeapYearVariable
  {
    private int _year;

    public int GetYear()
    {
      return _year;
    }

    public void SetYear(int newYear)
    {
      _year = newYear;
    }


    public bool IsLeapYear(int year)
    {
      if (year % 400 == 0)
      {
        return true;
      }
      else if (year % 100 == 0)
      {
        return false;
      }
      else
      {
        return year % 4 == 0;
      }

    }
  }
}
