//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestingApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Question
    {
        public int IdQ { get; set; }
        public int IdAdmin { get; set; }
        public int IdSubject { get; set; }
        public string Question1 { get; set; }
        public int IdType { get; set; }
        public string Answer_A { get; set; }
        public string Answer_B { get; set; }
        public string Answer_C { get; set; }
        public string Answer_D { get; set; }
    
        public virtual AdminData AdminData { get; set; }
        public virtual QuestionType QuestionType { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
