using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBlazor.Services
{
    public class EmailRequirement : IAuthorizationRequirement
    {
        public string EmailSuffix { get; }

        public EmailRequirement(string emailSuffix)
        {
            EmailSuffix = emailSuffix;
        }
    }

    public class EmailAuthHandler : AuthorizationHandler<EmailRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, EmailRequirement requirement)
        {
            if (context.User.Identity.Name.EndsWith(requirement.EmailSuffix))
                context.Succeed(requirement);

            return Task.CompletedTask;  
        }
    }
}
