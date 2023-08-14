using Microsoft.AspNetCore.Mvc;

namespace CoursesMVCTypre.Models
{
    public class instructors 
    {
       public int Id { get; set; }
        public string Name { get; set; }

        internal string GetName()
        {
            return " Divy Patel";
        }
        internal int GetAge()
        {
            return 34;
        }
    }
}
