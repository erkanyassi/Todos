//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace todolist.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class todo
    {
        public int id { get; set; }
        public string todo_title { get; set; }
        public string todo_content { get; set; }
        public System.DateTime date { get; set; }
    }
}
