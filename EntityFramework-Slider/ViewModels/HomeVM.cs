using EntityFramework_Slider.Models;
using System.Composition;
using System.Reflection.Metadata;

namespace EntityFramework_Slider.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public SliderInfo SliderInfo { get; set; }
      
        public IEnumerable<Expert> Experts { get; set; }
        
        public IEnumerable<Author> Authors { get; set; }
       
        public About About { get; set; }
     
        public ExpertHeader ExpertHeader { get; set; }
     

    }
}
