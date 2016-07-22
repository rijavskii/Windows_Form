using System.Data.Entity;

namespace EF_Example
{
    public class ExampleDbContext:DbContext
    {
        public ExampleDbContext() : base("exampleDb")
        {
            Database.SetInitializer<ExampleDbContext>(new ExampleDbInitializer( ));
        }

        public
    }
}