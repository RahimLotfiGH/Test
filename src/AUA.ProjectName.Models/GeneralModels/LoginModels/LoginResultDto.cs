﻿using AUA.ProjectName.DomainEntities.Entities.Accounting.UserAccessAggregate;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;

namespace AUA.ProjectName.Models.GeneralModels.LoginModels
{
    public class LoginResultDto : BaseViewModel
    {
        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IEnumerable<int> RoleIds { get; set; }

        public IEnumerable<EUserAccess> UserAccessIds { get; set; }

        public string RefreshToken { get; set; }

        public DateTime ExpiresIn { get; set; }

        public string AccessToken { get; set; }
        

    }
}
