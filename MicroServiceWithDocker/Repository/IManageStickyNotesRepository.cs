using MicroServiceWithDocker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceWithDocker.Repository
{
    public interface IManageStickyNotesRepository
    {
        void DeleteStickyNotes(int Id);
        ManageStickNotes GetManageStickyNotesById(int Id);
        Task<IList<ManageStickNotes>> GetManageStickNotes();
        void InsertManageStickNotes(ManageStickNotes manageStickNotes);
        void UpdateManageStickNotes(ManageStickNotes manageStickNotes);
        void Save();
    }
}
