using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliHack.Data
{
    public class IdeasService : IDisposable
    {

        PoliHackContext dbcon;

        public IdeasService()
        {
            dbcon = new PoliHackContext();
        }

        public void Dispose()
        {
            dbcon.Dispose();
        }

        public Task<ToDoIdea[]> FetchAllIdeasAsync()
        {
            return Task.FromResult(dbcon.ToDoIdeas.ToArray());
        }
    }
}
