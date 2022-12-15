﻿using Invoice.Applicaion.CQRS.Notifications;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Applicaion.CQRS.Handlers
{
    public class EmailHandler : INotificationHandler<ProductAddedNotification>
    {
        private readonly ILogger<EmailHandler> _logger;
        public EmailHandler(ILogger<EmailHandler> logger)
        {
            _logger = logger;
        }
        public Task Handle(ProductAddedNotification notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Email sent");
            return Task.CompletedTask;
        }
    }
}
