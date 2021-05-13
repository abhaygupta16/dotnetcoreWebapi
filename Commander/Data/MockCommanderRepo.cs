using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command> {
                 new Command { Id = 1, HowTo = "create a dotnet project", Line = "in Vs", Platform = "Any platform" },
                 new Command { Id = 2, HowTo = "create a Java project", Line = "in Vs", Platform = "Any platform" },
                  new Command { Id = 3, HowTo = "create a Angular project", Line = "in Vs", Platform = "Any platform" }

            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 1, HowTo = "create a dotnet project", Line = "in Vs", Platform = "Any platform" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
