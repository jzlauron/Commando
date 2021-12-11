using Commando.Models;
using Microsoft.EntityFrameworkCore;

namespace Commando.Data
{
    //inherits db base class
    public class CommandoContext : DbContext
    {
        //define a ctor that uses base to call the constructor of the divide class DbContext
        //dbContextOptions of [type] carries the configuration information needed to configure the DbContext
        public CommandoContext(DbContextOptions<CommandoContext> opt) : base(opt)
        {
            
        }
        //create a representation of the command model in our database is to use a DbSet so - make prop
        public DbSet<Command> Commands { get; set; }
    }
}