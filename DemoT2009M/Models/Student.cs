namespace DemoT2009M.Models
{
    public class Student
    {
        private string rollNumber;

        public string GetRollNumber()
        {
            if (string.IsNullOrEmpty(rollNumber))
            {
                return "RollNumber has no value";
            }

            return rollNumber;
        }

        public void SetRollNumber(string rollNumber)
        {
            if (string.IsNullOrEmpty(rollNumber))
            {
                return;
            }

            this.rollNumber = rollNumber;
        }
    }
}