using Microsoft.AspNetCore.SignalR;

namespace RealTimeChatAndNotifications.Backend.Notifications
{
    public class NotificationsHub : Hub
    {
        public NotificationsHub() { }

        public async Task BroadCastNotificaiton(string notification)
        {
            await Clients.All.SendAsync("NotificationReceived", notification);
        }
    }
}
