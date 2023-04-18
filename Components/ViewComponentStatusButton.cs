
//Created by Uday Chinhamora
//18 April 2023
//Website Add Tag Helper & View Components

//Add a view component for the status button (to do, in progress, quality assurance(qa), and done). 
using Microsoft.AspNetCore.Mvc;

using System.Linq;

using UdayChinhamoraWebsite.Models;

namespace UdayChinhamoraWebsite.Components
{
    public class ViewComponentStatusButton :ViewComponent
    {

        private TicketContext Context { get; set; }
        public ViewComponentStatusButton(TicketContext ctx) => Context = ctx;
        public IViewComponentResult Invoke(string selectedStatusValue)
        {
            var statuses = Context.Statuses.ToList().OrderBy(x => x.Name); // statuses is a list of statuses from the dbcontext ordered by name
            var viewModel = new StatusDropDownViewModel
            {
                SelectedStatus = selectedStatusValue,
                DefaultStatus = "td",
                Statuses = statuses.ToDictionary(x => x.Id.ToString(), x => x.Name.ToString())
            };
            return View(viewModel);
        }
    }
}
    }
}
