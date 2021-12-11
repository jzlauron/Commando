using System.Collections.Generic;
using Commando.Models;

namespace Commando.Data
{
    //repository interface
    //list of methods / signatures that you are gouing to provide to consumers
    //CRUD operation repository 
    public interface ICommandoRepo
    {
        
        bool SaveChanges();


        //return type
        //defining operations/methods via this interface to provide to consumers of this repo
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        //denote an ability to create a data on our database
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);
        

    }
}