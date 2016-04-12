using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Sys
{
    public class SysSampleModel
    {
        [Display(Name = "ID")]
        public string Id { get; set; }

        [StringLength(12,MinimumLength=4,ErrorMessage="名称长度必须介于(4-12)之间哦！")]
        [Display(Name = "名称")]
        public string Name { get; set; }


        [Display(Name = "年龄",Description="年龄必须在0-150之间")]
        [Range(0, 150)]
        public int? Age { get; set; }

        [Display(Name = "生日")]
        public DateTime? Bir { get; set; }

        [Display(Name = "照片")]
        public string Photo { get; set; }


        [Display(Name = "简介")]
        public string Note { get; set; }

        [Display(Name = "创建时间")]
        public DateTime? CreateTime { get; set; }

    }

}
