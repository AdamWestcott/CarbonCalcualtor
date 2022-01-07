using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Net5.BlazorIntegrationDemo.Controllers
{
    public class StoredItems
    {
        private static List<Emissions> Emissions = new List<Emissions>();
        public event Action onChange;

        public void setEmission(List<Emissions> newList)
        {
            Emissions = newList;
            NotifyStateChanged();
        }

        public List<Emissions> getEmissions()
        {
            return Emissions;
        }

        private void NotifyStateChanged()
        {
            onChange?.Invoke();
        }
    }
}
