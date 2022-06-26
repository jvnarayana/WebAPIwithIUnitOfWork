using System;
namespace RestAPIProjectForRepositoryPattern.Entities
{
    public class Developer
    {
        public Developer()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string location { get; set; }
    }
}
