namespace XConferenceApp.Models.Interfaces
{
    public interface IModel<TKey>
    {
        TKey Id { get; set; }
    }
}