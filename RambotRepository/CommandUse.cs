//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RambotRepository
{
    using System;

    public partial class CommandUse
    {
        public int Id { get; set; }
        public System.Guid Rid { get; set; }
        public System.DateTime Time { get; set; }
        public string Command { get; set; }
        public string arg { get; set; }
        public Nullable<int> argCount { get; set; }
    
        public virtual RamUser RamUser { get; set; }
    }
}
