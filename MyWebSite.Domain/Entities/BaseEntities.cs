namespace MyWebSite.Domain.Entities
{
    public abstract class BaseEntities
    {
        public BaseEntities()
        { 
            Id = Guid.NewGuid();
            IsActive = true;
            CreatedDate = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime UpdateDate { get; private set; }

        public void Deactive()
        {
            IsActive = false;
        }
        public void Active()
        {
            IsActive = true;
        }
        public void AddUpdateDate()
        {
            UpdateDate = DateTime.Now;
        }
    }
}
