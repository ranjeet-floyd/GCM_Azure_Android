/*
 * Ranjeet 
 * 31-Dec-14
 * Used to send GCM message
 */
using System;
using Microsoft.ServiceBus.Notifications;
using System.Configuration;
namespace SendToNotificationHub
{
    public class SendGCMNotification
    {
        //public static void Main()
        //{
        //    SendNotificationAsync("Welcome to Crebit !!");
        //    Console.ReadLine();
        //}

        
        public static async void SendNotificationAsync(string message, string connectionString, string hubName)
        {
            NotificationHubClient hub = NotificationHubClient.CreateClientFromConnectionString(connectionString, hubName);
            //await hub.SendGcmNativeNotificationAsync("{ \"data\" : {\"msg\":\"Hello Crebit from  Ranjeet!\"}}");
            await hub.SendGcmNativeNotificationAsync("{ \"data\" : {\"msg\":\"" + message + "\"}}");
        }
    }

}