namespace Pizzeria_Simone.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }


        public Pizza()
        {

        }

        public Pizza(int id, string title, string Description, string image, float Price)
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description; 
            this.Image = Image;
            this.Price = Price;

        }
    }
}
