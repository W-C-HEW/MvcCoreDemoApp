using MvcCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreApp.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetCommands();
        void AddCommand(Command cmd);
        bool saveChanges();
    }
}
