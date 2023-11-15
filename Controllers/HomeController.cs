using FirstWebApp.Models;
using FirstWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeVM vm = new HomeVM();

            // Banner Slider Section
            vm.BannerSliders.Add(new BannerSlider
            {
                Id = 1,
                Title = "Women",
                Description = "This section is about Women",
                ImgUrl = "woman.jpeg"
            });
            vm.BannerSliders.Add(new BannerSlider
            {
                Id = 2,
                Title = "Men",
                Description = "This section is about Men",
                ImgUrl = "man.jpg"
            });
            vm.BannerSliders.Add(new BannerSlider
            {
                Id = 3,
                Title = "Kids",
                Description = "This section is about Kids",
                ImgUrl = "kid.jpg"
            });
            vm.BannerSliders.Add(new BannerSlider
            {
                Id = 4,
                Title = "Accesories",
                Description = "This section is about Accesories",
                ImgUrl = "accesories.jpg"
            });

            // Men Slider Section
            vm.GenderSliders.Add(new GenderSlider
            {
                Id= 1,
                Title = "Sweater",
                Price = 20.99,
                ImgUrl = "model-man-1.webp",
                Gender = "man"
            });
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 2,
                Title = "T-Shirt",
                Price = 40.99,
                ImgUrl = "model-man-2.jpg",
                Gender = "man"
            });
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 3,
                Title = "Shirt",
                Price = 10.99,
                ImgUrl = "model-man-3.jpg",
                Gender = "man"
            });
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 4,
                Title = "Suit",
                Price = 120.99,
                ImgUrl = "model-man-1.webp",
                Gender = "man"
            });

            // Women Slider Section
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 5,
                Title = "Dress",
                Price = 35.99,
                ImgUrl = "model-woman-1.jpg",
                Gender = "woman"
            });
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 6,
                Title = "Long-Sleeve Top",
                Price = 55.99,
                ImgUrl = "model-woman-3.jpg",
                Gender = "woman"
            });
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 7,
                Title = "Skirt",
                Price = 95.99,
                ImgUrl = "model-woman-2.jpg",
                Gender = "woman"
            });
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 8,
                Title = "Hoodie",
                Price = 99.99,
                ImgUrl = "model-woman-3.jpg",
                Gender = "woman"
            });

            // Kids Slider Section
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 9,
                Title = "Shorts",
                Price = 13.99,
                ImgUrl = "model-kid-1.webp",
                Gender = "kid"
            });
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 10,
                Title = "Polo T-Shirt",
                Price = 19.99,
                ImgUrl = "model-kid-3.webp",
                Gender = "kid"
            });
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 11,
                Title = "Shoes",
                Price = 99.99,
                ImgUrl = "model-kid-2.jpg",
                Gender = "kid"
            });
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 12,
                Title = "Leather Jacket",
                Price = 99.99,
                ImgUrl = "model-kid-3.webp",
                Gender = "kid"
            });

            return View(vm);
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Products()
        {
            HomeVM vm = new HomeVM();

            // Men Slider Section
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 1,
                Title = "Sweater",
                Price = 20.99,
                ImgUrl = "model-man-1.webp",
                Gender = "man"
            });
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 2,
                Title = "T-Shirt",
                Price = 40.99,
                ImgUrl = "model-man-2.jpg",
                Gender = "man"
            });
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 3,
                Title = "Shirt",
                Price = 10.99,
                ImgUrl = "model-man-3.jpg",
                Gender = "man"
            });
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 4,
                Title = "Suit",
                Price = 120.99,
                ImgUrl = "model-man-1.webp",
                Gender = "man"
            });

            // Women Slider Section
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 5,
                Title = "Dress",
                Price = 35.99,
                ImgUrl = "model-woman-1.jpg",
                Gender = "woman"
            });
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 6,
                Title = "Long-Sleeve Top",
                Price = 55.99,
                ImgUrl = "model-woman-3.jpg",
                Gender = "woman"
            });
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 7,
                Title = "Skirt",
                Price = 95.99,
                ImgUrl = "model-woman-2.jpg",
                Gender = "woman"
            });
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 8,
                Title = "Hoodie",
                Price = 99.99,
                ImgUrl = "model-woman-3.jpg",
                Gender = "woman"
            });

            // Kids Slider Section
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 9,
                Title = "Shorts",
                Price = 13.99,
                ImgUrl = "model-kid-1.webp",
                Gender = "kid"
            });
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 10,
                Title = "Polo T-Shirt",
                Price = 19.99,
                ImgUrl = "model-kid-3.webp",
                Gender = "kid"
            });
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 11,
                Title = "Shoes",
                Price = 99.99,
                ImgUrl = "model-kid-2.jpg",
                Gender = "kid"
            });
            vm.GenderSliders.Add(new GenderSlider
            {
                Id = 12,
                Title = "Leather Jacket",
                Price = 99.99,
                ImgUrl = "model-kid-3.webp",
                Gender = "kid"
            });


            return View();
        }

        public IActionResult SingleProduct() 
        {
            return View();
        }

        public IActionResult ContactUs() 
        {
            return View();
        }
    }
}
