// -----------------------WRONG--------------------

public interface ITeach
{
   void CreateDuty();
   void GiveDuty();
   void WorkOnDuty();
}

public class Teacher : ITeach
{
   public void GiveDuty()
   {
      //Code to assign a job.
   }
   public void CreateDuty()
   {
      //Code to create a lower-level job.
   }
   public void WorkOnDuty()
   {
      //Code to implement perform assigned job.
   }
}

public class Director: ITeach
{
   public void GiveDuty()
   {
      //Code to assign a job.
   }
   public void CreateDuty()
   {
      //Code to create a lower-level job.
   }
   public void WorkOnDuty()
   {
      throw new Exception("Director can't work on Duty");
   }
}

// --------------------CORRECT--------------------------------------------

public interface IAssistant
{
   void WorkOnDuty();
}

public interface ITeach
{
   void GiveDuty();
   void CreateDuty();
}

// Then the implementation becomes:
public class Assistant : IAssistant
{
   public void WorkOnDuty()
   {
      //code to implement to work on the lower-level.
   }
}
public class Director: ITeach
{
   public void GiveDuty()
   {
      //Code to assign a job
   }
   public void CreateDuty()
   {
     //Code to create a lower-level taks from a job.
   }
}

public class Techer: IAssistant, ITeach
{
   public void GiveDuty()
   {
      //Code to assign a job
   }
   public void CreateDuty()
   {
      //Code to create a lower-level job from a job.
   }
   public void WorkOnDuty()
   {
      //code to implement to work on the job.
   }
}
