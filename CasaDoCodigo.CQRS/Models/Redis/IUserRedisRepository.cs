﻿using CasaDoCodigo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVC.Model.Redis
{
    public interface IUserRedisRepository
    {
        Task<List<UserNotification>> GetUserNotificationsAsync(string clienteId);
        Task<List<UserNotification>> GetUnreadUserNotificationsAsync(string clienteId);
        Task AddUserNotificationAsync(string clienteId, UserNotification userNotification);
        Task MarkAllAsReadAsync(string clienteId);
    }
}