namespace Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_Task_Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int s_Task_DeptID { get; set; }

        [StringLength(30)]
        public string s_Task_DeptName { get; set; }

        [StringLength(30)]
        public string s_Task_DeptName_EN { get; set; }
    }
}
