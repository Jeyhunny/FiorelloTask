namespace EntityFramework_Slider.ViewModels
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }
        public string Descriton { get; set; }
        public ICollection<Say> Says { get; set; }

    }
}