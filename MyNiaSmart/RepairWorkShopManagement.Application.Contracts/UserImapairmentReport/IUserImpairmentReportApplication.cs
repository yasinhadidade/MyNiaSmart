﻿using _0_Framework.Utilities;
using System.Collections.Generic;

namespace RepairWorkShopManagement.Application.Contracts.UserImapairmentReport
{
    public interface IUserImpairmentReportApplication
    {
        OperationResult Create(CreateUserImpairmentReport command);
        OperationResult Edit(EditUserImpairmentReport command);

        OperationResult AcceptToHandleByRepairManPanelId(long repairManPanelId);


        //Using For RepairMan To see all userImpairments
        List<UserImpairmentReportViewModel> GetAll();

        //Using For User To See their ImpairmentReports With Status
        List<UserImpairmentReportViewModel> GetAllByUserId(long userId);

        //using For RepairMan to See the ImpairmentReports That he accepted
        List<UserImpairmentReportViewModel> GetAllByRepairManPanelId(int repairManPanelId);
    }
}
