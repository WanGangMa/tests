﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;

namespace Service.ServiceImp
{
    /// <summary>
    /// Service 授权模块关系处理类
    ///  2016-05-19
    /// </summary>
    public class PermissionManage : RepositoryBase<Domain.SYS_PERMISSION>, IService.IPermissionManage
    {
        /// <summary>
        /// 根据系统ID获取所有模块的权限ID集合
        /// </summary>
        public List<int> GetPermissionIdBySysId(string sysId)
        {
            try
            {
                string sql = "select p.id from sys_permission p where exists(select 1 from sys_module t where t.fk_belongsystem=@sysid and t.id=p.moduleid)";
                DbParameter para = new SqlParameter("@sysid", sysId);
                return this.SelectBySql<int>(sql, para);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }

}