using MvcCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreApp.Data
{
    public class CommanderRepo : ICommanderRepo
    {
        private readonly ApplicationDbContext _db;
        public CommanderRepo(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Command> GetCommands()
        {
            return _db.Command.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _db.Command.Find(id);
        }

        public void AddCommand(Command cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _db.Command.Add(cmd);
        }

        public bool saveChanges()
        {
            return (_db.SaveChanges() >= 0);
        }

    }
}
