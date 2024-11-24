namespace AzureQueue_HW1.Services.Abstracts
{
    public interface IDiscountQueueService
    {
        Task SendMessageAsync(string message);
        Task<string> ReceiveMessageAsync();
    }
}
