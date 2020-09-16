using MicroServiceWithDocker.DBContexts;
using MicroServiceWithDocker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceWithDocker.Repository
{
    public class ManageStickyNotesRepository : IManageStickyNotesRepository
    {
        private readonly ManageStickyNotesContext _manageStickyNotesContext;

        public ManageStickyNotesRepository(ManageStickyNotesContext manageStickyNotesContext) {
            _manageStickyNotesContext = manageStickyNotesContext;
        }

        public void DeleteStickyNotes(int Id)
        {
            var StickyNotes = _manageStickyNotesContext.ManageStickNotes.Find(Id);
            _manageStickyNotesContext.ManageStickNotes.Remove(StickyNotes);
            Save();
        }

        public ManageStickNotes GetManageStickyNotesById(int Id)
        {
            return _manageStickyNotesContext.ManageStickNotes.Find(Id);
        }

        //public async Task<List<ManageStickNotes>> GetManageStickNotes()
        //{
        //    return _manageStickyNotesContext.ManageStickNotes.ToList();
        //}

        public void InsertManageStickNotes(ManageStickNotes manageStickNotes)
        {
            _manageStickyNotesContext.Add(manageStickNotes);
            Save();
        }

        public void Save()
        {
            
            _manageStickyNotesContext.SaveChanges();
        }

        public void UpdateManageStickNotes(ManageStickNotes manageStickNotes)
        {
            _manageStickyNotesContext.Entry(manageStickNotes).State = EntityState.Modified;
            Save();
        }

        public async Task<IList<ManageStickNotes>> GetManageStickNotes()
        {
            return _manageStickyNotesContext.ManageStickNotes.Where(x=>x.IsDeleted == false).ToList();
        }
    }
}
