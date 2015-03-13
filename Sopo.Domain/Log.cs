using Sopo.Domain.BaseTypes;
using Sopo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Sopo.Domain
{
    public class Log : BaseRecord, IDateable
    {
        public Log()
        {

        }
        public Log(string text)
        {
            this.Date = DateTime.Now;
            this.Text = text;
        }
        public Log(Exception ex)
        {
            this.Date = DateTime.Now;
            this.Text = ex.Message;
        }

        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Text { get; set; }
    }
}
