using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab2
{
  class Test
  {
    public string subject { get; set; }
    public bool pass { get; set; }

    public Test(string testSubject, bool testPass)
    {
      this.subject = testSubject;
      this.pass = testPass;
    }
    public Test()
    {
      this.subject = "Операционные системы";
      this.pass = true;
    }
    public override string ToString()
    {
      return "Предмет: " + subject + " Зачёт: " + pass.ToString();
    }
  }
}