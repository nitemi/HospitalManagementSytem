using CareTrack.Service.Models;


namespace CareTrack.Service.Services
{
    public  interface IEmailService
    {
        void SendEmail(Message message);  
    }
}
