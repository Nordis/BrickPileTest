using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BrickPile.Domain.Models;
using BrickPile.Domain;
using BrickPileTest.Controllers;

namespace BrickPileTest.Models
{
    [PageModel(Name = "Start page", ControllerType = typeof(HomeController))]
    public class Home : PageModel
    {
        [Display(Name = "Main heading")]
        public string Heading { get; set; }
        [DataType(DataType.Html)]
        [Display(Name = "Hero text")]
        public string HeroText { get; set; }
    }
}