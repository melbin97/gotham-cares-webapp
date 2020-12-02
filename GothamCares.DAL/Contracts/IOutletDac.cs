using GothamCares.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GothamCares.DAL.Contracts
{
    public interface IOutletDac
    {
        Task<List<Outlet>> GetAllOutlets();
    }
}
