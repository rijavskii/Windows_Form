using System.Data.Entity;

namespace EF_Example
{
    public class ExampleDbInitializer : IDatabaseInitializer<ExampleDbContext>
    {
        public void InitializeDatabase(ExampleDbContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}