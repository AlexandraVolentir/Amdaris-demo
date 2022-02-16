// -------------------- WRONG -------------------------

public class StudentLoan{
   public double potential {get;set;}
   public double yearsOfStudy {get;set; }
}
   public class LoanWriteUp
   {
     public double TotalAnalysisCalc(StudentLoan[] arrayOfStudentLoans)  {

      double payingPotential;
      foreach(var obj in arrayOfStudentLoans)
      {
         payingPotential += obj.yearsOfStudy * obj.potential;
      }
      return payingPotential;
   }
}

public class StudentLoan{
   public double potential {get;set;}
   public double yearsOfStudy {get;set; }
}
public class PersonalLoan{
   public double salary {get;set;}
}
public class LoanWriteUp
{
  public double TotalAnalysisCalc(object[] arrObjects)
   {
      double payingPotential = 0;
      StudentLoan stdLoan;
      PersonalLoan persLoan;
      foreach(var obj in arrObjects)
      {
         if(obj is StudentLoan)
         {
            payingPotential += obj.yearsOfStudy * obj.potential;
         }
         else
         {
            PersonalLoan = (PersonalLoan)obj;
            payingPotential = persLoan.salary - persLoan.credit/12;
         }
      }
      return payingPotential;
   }
}

// ------------------------ RIGHT -------------------------------------

public abstract class Loan
{
   public abstract double PayingPotential();
}

public class StudentLoan: Loan
{
  public double potential {get;set;}
  public double yearsOfStudy {get;set; }
   public override double PayingPotential()
   {
      return yearsOfStudy * potential;
   }
}
public class PersonalLoan: Loan
{
   public double salary {get;set;}
   public override double PayingPotential()
   {
      return salary - credit/12;
   }
}

public class LoanWriteUp
{
   public double TotalAnalysisCalc(Loan[] arrLoans)
   {
      double payingPotential =0;
      foreach(var objLoan in arrLoans)
      {
         payingPotential += objLoan.PayingPotential();
      }
      return payingPotential;
   }
}
