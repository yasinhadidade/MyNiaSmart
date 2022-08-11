﻿using _0_Framework.Domain;
using RepairWorkShopManagement.Application.Contracts.UserImapairmentReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairWorkShopManagement.Domain.UserImapairmentReportAgg
{
    public interface IUserImapairmentReportRepository : IRepository<long, UserImapairmentReport>
    {
     

        //using For RepairMan to See the ImpairmentReports That he accepted
        List<UserImapairmentReport> GetAllByRepairManPanelId(int repairManPanelId);

        //TO Show  list of user current impairmentReports that are processing
        List<UserImapairmentReport> GetCurrentUserImpairmentReports(long userId);
    }
}
