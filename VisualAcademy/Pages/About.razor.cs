using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisualAcademy.Pages
{
    public  partial class About : ComponentBase
    {
        private readonly string title = "정보";

        private string subTitlte;

        public string SubTitle
        {
            get { return subTitlte; }
            set { subTitlte = value; }
        }

        protected override void OnInitialized()
        {
            SubTitle = DateTime.Now.ToShortDateString();
        }
    }
}
