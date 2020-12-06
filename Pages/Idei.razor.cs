using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoliHack.Pages
{
    public partial class Idei : IDisposable
    {
        private class IdeiModel
        {
            [Required]
            public string Mesaj { get; set; }
        }

        private IdeiModel ideiModel = new IdeiModel();
        private Data.PoliHackContext cnt = null;
        AuthenticationState userstate = null;

        [Inject]
        Data.IdeasService isv { get; set; }

        [Inject]
        IDbContextFactory<Data.PoliHackContext> DbFactory { get; set; }

        [Inject]
        AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        Data.ToDoIdea[] ideialtii, ideimele;

        protected override async Task OnInitializedAsync()
        {
            while(cnt==null)
            {
                try
                {
                    cnt = DbFactory.CreateDbContext();
                }
                catch
                {

                }
            }

            ideialtii = await isv.FetchAllIdeasAsync();

            userstate = await AuthenticationStateProvider.GetAuthenticationStateAsync();

            ideimele = ideialtii.Where(e => e.Username == userstate.User.Identity.Name).ToArray();

            await base.OnInitializedAsync();
        }

        protected override async void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
        }

        private async void Trimite()
        {
            if (userstate.User.Identity.IsAuthenticated)
            {
                Data.ToDoIdea msg = new Data.ToDoIdea()
                {
                    Username=userstate.User.Identity.Name,
                    Mesaj=ideiModel.Mesaj
                };

                cnt.ToDoIdeas.Add(msg);
                cnt.SaveChanges();
            }

            ideialtii = await isv.FetchAllIdeasAsync();
            ideimele = ideialtii.Where(e => e.Username == userstate.User.Identity.Name).ToArray();
        }

        public void Dispose()
        {
            cnt.Dispose();
        }
    }
}