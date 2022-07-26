﻿using _0_Framework.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Application.Contract.UserDevice
{
    public class CreateUserDevice
    {

        [Range(1,long.MaxValue,ErrorMessage =ValidationMessage.IsRequired)]
        public long UserId { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = ValidationMessage.IsRequired)]
        public long ProductId { get; set; }
    }
}
