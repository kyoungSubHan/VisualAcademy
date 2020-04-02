using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisualAcademy.Pages.Portfolios
{
    public partial class PortfolioWebsite
    {
        [Inject]
        public NavigationManager NavigationManagerRef { get; set; }
        protected override void OnInitialized()
        {
            
        }

        protected void GotoDotNetKorea()
        {
            NavigationManagerRef.NavigateTo("/");
        }
    }
}
