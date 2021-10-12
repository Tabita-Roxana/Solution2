using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Models;

namespace Assignment1.Data
{
    public class AdultsData:IAdultsData
    {

        private FileContext fileContext;

        public AdultsData(FileContext fileContext)
        {
            this.fileContext = fileContext;
        }

        public IList<Adult> GetAdults()
        {
            return fileContext.Adults;
        }

        public void AddAdult(Adult adult)
        {
            int max = fileContext.Adults.Max(a => a.Id);
            adult.Id = (++max);
            fileContext.Adults.Add(adult);
            fileContext.SaveChanges();
        }

        public void RemoveAdult(int adultId)
        {
            Adult toRemove = fileContext.Adults.First(a => a.Id == adultId);
            fileContext.Adults.Remove(toRemove);
            fileContext.SaveChanges();
        }

        public void Edit(Adult adult)
        {
            Adult toEdit = fileContext.Adults.First(a => a.Id == adult.Id);
            toEdit.Weight = adult.Weight;
            fileContext.SaveChanges();
        }

        public Adult Get(int id)
        {
            return fileContext.Adults.FirstOrDefault(a => a.Id == id);
        }
    }
}