namespace EntityFramework_Slider.ViewModels
{
    public class Say:BaseEntity
    {
        public string Image { get; set; }
        public string Descrition { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}