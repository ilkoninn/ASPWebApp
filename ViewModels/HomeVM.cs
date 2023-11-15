using FirstWebApp.Models;

namespace FirstWebApp.ViewModels
{
    public class HomeVM
    {
        public List<BannerSlider> BannerSliders { get; set; } = new List<BannerSlider>();
        public List<GenderSlider> GenderSliders { get; set;} = new List<GenderSlider>();

    }
}
