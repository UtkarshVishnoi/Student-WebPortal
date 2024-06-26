using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebPortal.Data
{
    [Table("tblStudent", Schema = "public")]
    public class StudentClass
    {
        [Key]
        public int id{ get; set; }
        public string? name { get; set; }
        public string username { get; set; }
        public string? course { get; set; }
        public string? hometown { get; set; }
        public int? semester { get; set; }
        public decimal? cgpa { get; set; }
        public DateOnly? dob { get; set; }
        public string password { get; set; }
        public int? dept_id { get; set; }
        public bool is_logged { get; set; }
    }
}
