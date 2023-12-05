using Microsoft.AspNetCore.Mvc;
using Task_15.Models.Entities;
using Task_15.ViewsModels.Home;

namespace Task_15.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            List<Product> products = new List<Product>
            {
                new Product {Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow, FilePath="services-01.jpg",Title="UI/UX design",Text="UI/UX design text"},
                new Product {Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow, FilePath="services-02.jpg",Title="Social Media",Text="Scoail Media text"},
                new Product {Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow, FilePath="services-03.jpg",Title="Marketing",Text="Marketing text"},
                new Product {Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow, FilePath="services-04.jpg",Title="Graphic",Text="Graphic text"},
                new Product {Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow, FilePath="services-05.jpg",Title="Digital",Text="Digital Marketing"},
                new Product {Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow, FilePath="services-06.jpg",Title="Market",Text="Market Research"},
                new Product {Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow, FilePath="services-07.jpg",Title="Business",Text="Business"},
                new Product {Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow, FilePath="services-08.jpg",Title="Graphic",Text="Grpahic text"},

            };

            List<Recent> recents = new List<Recent>
            {
                new Recent{Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow,  Title="Social Media" , Description="Ullamco laboris nisi ut aliquip ex", FilePath="recent-work-01.jpg"},
                new Recent{Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow,  Title="Web Marketing" , Description="Psum officia anim id est laborum.", FilePath="recent-work-02.jpg"},
                new Recent{Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow,  Title="R&D" , Description="Sum dolor sit consencutur", FilePath="recent-work-03.jpg"},
                new Recent{Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow,  Title="Public Relation" , Description="Lorem ipsum dolor sit amet", FilePath="recent-work-04.jpg"},
                new Recent{Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow,  Title="Branding" , Description="Put enim ad minim veniam", FilePath="recent-work-05.jpg"},
                new Recent{Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow,  Title="Creative Design" , Description="Mollit anim id est laborum.", FilePath="recent-work-06.jpg"},


            };

            HomeIndexViewModel model = new HomeIndexViewModel() { Products = products, Recents = recents };


            return View(model);

        }

        public IActionResult About()
        {
            List<AboutHeader> aboutHeaders = new List<AboutHeader>
            {
               new AboutHeader()
               {
                     Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow , Title="About Us" , Description=" Vector illustration credit goes to" ,Text=" website. Purple Buzz is provided by TemplateMo. Lorem ipsum dolor sit amet, consectetur." ,Url="http://freepik.com/",UrlText="FreePik" ,FilePath="banner-img-02.svg"
               }



            };
            List<About> abouts = new List<About>
            {
              new About (){  Id = Guid.NewGuid(),CreatedDate = DateTime.UtcNow , Description="Incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse commodo viverra." , FilePath="display-4 bx bxs-bulb text-light" , Title="Our Vision"},
              new About (){  Id = Guid.NewGuid(),CreatedDate = DateTime.UtcNow , Description=" Eiusmod tempor incididunt ut labore et dolore magna aliqua.\r\n  Ut enim ad minim veniam quis." , FilePath="display-4 bx bx-revision text-light" , Title="Our Mission"},
              new About (){  Id = Guid.NewGuid(),CreatedDate = DateTime.UtcNow , Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit,\r\n                        sed do eiusmod tempor." , FilePath="display-4 bx bxs-select-multiple text-light" , Title="Our Goal"}

            };

            HomeAboutViewModel model = new HomeAboutViewModel()
            {
                AboutHeaders = aboutHeaders,
                Abouts = abouts
            };
            return View(model);
        }
    }
}
